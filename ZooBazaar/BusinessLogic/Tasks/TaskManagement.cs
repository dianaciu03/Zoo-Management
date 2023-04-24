using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TaskManagement
    {
        private List<ZooTask> tasks;
        public TaskManagement() 
        {
            tasks = new List<ZooTask>();
        }

        public void ScheduleTask(string name, string description, DateTime taskDateTime, int taskLength, string specie, Animal animal)
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
            // taskStartHour, taskEndHour is task times that New/existing which does not have caretakers assigned.
            int newTaskStartHour = task.TaskDateTime.Hour;
            int newTaskEndHour = newTaskStartHour + (int)task.EstimatedDuration;

            ZooTask[] employeeTasks = GetTasksByCaretaker(employee.ID, task.TaskDateTime);
            foreach (ZooTask empTask in employeeTasks)
            {
                if (empTask.TaskDateTime.Hour < newTaskStartHour)
                {
                    if (empTask.TaskDateTime.Hour + empTask.EstimatedDuration > newTaskStartHour)
                        return false;
                }
                else if (empTask.TaskDateTime.Hour == newTaskEndHour)
                {
                    if (empTask.TaskDateTime.Minute + empTask.EstimatedDuration <= newTaskStartHour * 60)
                    {
                        return false;
                    }
                }
                else if (empTask.TaskDateTime.Hour >= newTaskEndHour)
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
