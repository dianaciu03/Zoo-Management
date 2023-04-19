using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public class TaskManagement
    {
        private List<ZooTask> tasks;
        public TaskManagement() 
        {
            tasks = new List<ZooTask>();
        }

        public void ScheduleTask(string name, string description, DateTime taskDateTime, double taskLength, string specie, Animal animal)
        {
            int id;
            if (tasks.Count() > 0)
                id = tasks.Last().ID + 1;
            else id = 1;

            if (animal != null)
                tasks.Add(new ZooTask(id, name, description, taskDateTime, taskLength, specie, animal));
            else 
                tasks.Add(new ZooTask(id, name, description, taskDateTime, taskLength, specie));
        }

        public void RemoveTaskByID(int id)
        {
            tasks.RemoveAt(tasks.FindIndex(f => f.ID == id));
/*            foreach (ZooTask task in tasks)
            {
                if (task.ID == id && task.Status == "Not started")
                {
                    tasks.Remove(task);
                }
            }*/
        }

        
        public Employee[] GetTaskEmployees(int taskID)
        {
            ZooTask task = (ZooTask)tasks.Where(x => x.ID == taskID);
            return task.GetAssignedEmployees().ToArray();
        }

        public ZooTask[] GetTasks()
        {
            return tasks.ToArray();
        }

        public ZooTask[] GetTasksByCaretaker(int employeeID)
        {
            List<ZooTask> foundTasks = new List<ZooTask>();
            foreach (ZooTask task in tasks)
            {
                if (task.GetAssignedEmployee(employeeID) != null)
                {
                    foundTasks.Add(task);
                }
            }
            return foundTasks.ToArray();
        }
        public ZooTask[] GetTasksByCaretaker(int employeeID, DateTime taskDate)
        {
            List<ZooTask> foundTasks = new List<ZooTask>();
            foreach (ZooTask task in tasks)
            {
                if (task.GetAssignedEmployee(employeeID) != null && taskDate.Date == task.TaskDateTime.Date)
                {
                    foundTasks.Add(task);
                }
            }
            return foundTasks.ToArray();
        }
        public bool CheckEmployeeAvailability(ZooTask task, Employee employee)
        {
            // New/existing which does not have caretakers assigned.
            int taskStartHour = task.TaskDateTime.Hour;
            int taskEndHour = taskStartHour + (int)task.EstimatedDuration;

            ZooTask[] employeeTasks = GetTasksByCaretaker(employee.ID, task.TaskDateTime);
            foreach (ZooTask empTask in employeeTasks)
            {
                int empTaskStartHour = empTask.TaskDateTime.Hour;
                int empTaskEndHour = empTask.TaskDateTime.Hour + (int)empTask.EstimatedDuration;

                if (empTaskStartHour < taskStartHour)
                {
                    if (empTaskEndHour > taskStartHour)
                        return false;
                }
                else if (empTaskStartHour >= taskEndHour)
                {
                    continue;
                }
                else return false;
            }
            return true;
        }

        public void CompleteTask(ZooTask task)
        {
            task.Status = "Finished";
        }
    }
}
