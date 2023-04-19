using System;
using System.Collections.Generic;
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

        public void AssignTask(ZooTask task, CareTaker employee)
        {
            task.AssignEmployee(employee);
        }
        public CareTaker[] GetTaskEmployees(int taskID)
        {
            ZooTask task = (ZooTask)tasks.Where(x => x.ID == taskID);
            return task.GetAssignedEmployees().ToArray();
        }

        public ZooTask[] GetTasks()
        {
            return tasks.ToArray();
        }

        public void CompleteTask(ZooTask task)
        {
            task.Status = "Finished";
        }
    }
}
