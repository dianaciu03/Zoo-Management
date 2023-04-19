using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ZooTask
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TaskDateTime { get; set; }
        public double EstimatedDuration { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public Animal Animal { get; set; }
        private List<CareTaker> assignedEmployees;

        //task where animal is specified
        public ZooTask(int ID, string Name, string Description, DateTime TaskDateTime, double EstimatedDuration, string Species, Animal Animal) 
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.TaskDateTime = TaskDateTime;
            this.EstimatedDuration = EstimatedDuration;
            this.Status = "Not started";
            this.Species = Species;
            this.Animal = Animal;
            this.assignedEmployees = new List<CareTaker>();
        }

        //task where only specie is specified, no specific animal selected
        public ZooTask(int ID, string Name, string Description, DateTime TaskDateTime, double EstimatedDuration, string Species) 
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.TaskDateTime = TaskDateTime;
            this.EstimatedDuration = EstimatedDuration;
            this.Status = "Not started";
            this.Species = Species;
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
