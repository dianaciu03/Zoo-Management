using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class ScheduleManagement
    {
        ShiftRepository shiftRepo = new ShiftRepository();
        IEmployeeManagement employeeManagement = new EmployeeManagement(new EmployeeRepository());
        public ScheduleManagement() { }

        public Shift[] GetShifts()
        {
            List<Shift> shifts = new List<Shift>();
            foreach(ShiftDTO shiftDTO in shiftRepo.GetAllShifts())
            {
                shifts.Add(new Shift(employeeManagement.GetEmployeeById(shiftDTO.EmployeeId), shiftDTO.ShiftTime));
            }
            return shifts.ToArray();
        }
        
        public Shift[] GetShifts(DateTime date)
        {
            List<Shift> shifts = new List<Shift>();
            foreach(ShiftDTO shiftDTO in shiftRepo.GetAllShifts())
            {
                shifts.Add(new Shift(employeeManagement.GetEmployeeById(shiftDTO.EmployeeId), shiftDTO.ShiftTime));
            }
            return shifts.ToArray();
        }

        public void AddShifts(Shift[] shifts)
        {
            foreach(Shift shift in shifts)
            {
                ShiftDTO shiftDto = new ShiftDTO()
                {
                    EmployeeId = shift.Employee.ID,
                    ShiftTime = shift.ShiftTime
                };
                shiftRepo.AddShift(shiftDto);
            }
        }
    }
}
