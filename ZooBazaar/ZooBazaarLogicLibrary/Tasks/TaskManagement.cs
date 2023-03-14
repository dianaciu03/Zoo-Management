using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public class TaskManagement
    {
        private List<Task> tasks;
        public TaskManagement() 
        {
            tasks = new List<Task>();
        }

        public void ScheduleTask(string name, string description, DateTime taskDateTime, bool status, string animal, List<CareTaker> assignedEmployees)
        {
            int id;
            if (tasks.Count() > 0)
                id = tasks.Last().ID + 1;
            else id = 1;

            tasks.Add(new Task(id, name, description, taskDateTime, status, animal, new List<CareTaker>()));
        }
        public void AssignTask(Task task, CareTaker employee)
        {
            task.AssignEmployee(employee);
        }
        public CareTaker[] GetTaskEmployees(int taskID)
        {
            Task task = (Task)tasks.Where(x => x.ID == taskID);
            return task.GetAssignedEmployees().ToArray();
        }

        public Task[] GetTasks()
        {
            return tasks.ToArray();
        }

        public void CompleteTask(Task task)
        {
            task.Status = true;
        }
    }
}
