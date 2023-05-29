using BusinessLogic;
using BusinessLogic.Employees;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AutomaticScheduling
    {
        TaskManagement taskManagement = new TaskManagement();
        public AutomaticScheduling()
        {
            
        }
        public Shift[] ScheduleEmployeesForShifts(CaretakerWithHours[] careTakers)
        {
            List<Shift> shifts = new List<Shift>();

            DateTime today = DateTime.Today;
            int daysUntilMonday = 7;
            if (today.DayOfWeek != DayOfWeek.Monday)
            {
                daysUntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            }
            DateTime nextMonday = DateTime.Today.AddDays(daysUntilMonday);
            DateTime nextShift = nextMonday;
            foreach (CaretakerWithHours careTaker in careTakers)
            {
                int daysPerWeek = careTaker.ContractHours / 8;
                for (int i = 0; i < daysPerWeek; i++)
                {
                    shifts.Add(new Shift(careTaker.Employee, new DateTime(nextShift.Year, nextShift.Month, nextShift.Day, 8, 0, 0)));
                    shifts.Add(new Shift(careTaker.Employee, new DateTime(nextShift.Year, nextShift.Month, nextShift.Day, 13, 0, 0)));
                    if (nextShift.DayOfWeek == DayOfWeek.Sunday)
                    {
                        nextShift = nextMonday;
                    }
                    else
                    {
                        nextShift = nextShift.AddDays(1);
                    }
                }
            }
            return shifts.ToArray();
        }

        public bool AssignTasksAutomatically(List<ZooTask> allTasks)
        {
            ScheduleManagement scheduleManagement= new ScheduleManagement();
            
            bool wereAllTasksAssigned = true;
            foreach (ZooTask task in allTasks)
            {
                Employee[] careTakers = scheduleManagement.GetAvailableEmp(task.TaskDateTime.Date);
                bool wasAssigned = false;
                if (task.TaskDateTime.Date < DateTime.Today.Date)
                {
                    continue;
                }
                if(task.Status == "Assigned")
                {
                    continue;
                }
                foreach(Employee careTaker in careTakers) 
                {
                    if (taskManagement.CheckEmployeeAvailability(task, careTaker))
                    {
                        taskManagement.AssignEmployee(task, careTaker);
                        wasAssigned= true;
                        break;
                    }
                }
                if (!wasAssigned)
                {
                    wereAllTasksAssigned = false;
                }
                
            }
            return wereAllTasksAssigned;
        }
    }
}
