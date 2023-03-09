using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TaskDateTime { get; set; }
        public bool Status { get; set; }
        public string Animal { get; set; }
        private List<CareTaker> assignedEmployees;
        public Task(int ID, string Name, string Description, DateTime TaskDateTime, bool Status, string Animal, List<CareTaker> assignedEmployees) 
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.TaskDateTime = TaskDateTime;
            this.Status = false;
            this.Animal= Animal;
            this.assignedEmployees = new List<CareTaker>();
        }

        public void AssignEmployee(CareTaker employee)
        {
            assignedEmployees.Add(employee);
        }

        public CareTaker[] GetAssignedEmployees()
        {
            return assignedEmployees.ToArray();
        }
    }
}
