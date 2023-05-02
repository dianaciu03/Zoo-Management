using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ZooTask
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EnclosureArea { get; set; }
        public int EnclosureNumber { get; set; }
        public string Description { get; set; }
        public DateTime TaskDateTime { get; set; }
        public int EstimatedDuration { get; set; } //minutes
        public string Status { get; set; }
        public string Species { get; set; }
        public Animal? Animal { get; set; }
        private List<Employee> assignedEmployees;

        public ZooTask()
        {

        }

        //task where animal is specified
        public ZooTask(int ID, string Name, string Description, string EnclosureArea, int EnclosureNumber, DateTime TaskDateTime, int EstimatedDuration, string Status, string Species, Animal? Animal) 
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.EnclosureArea = EnclosureArea;
            this.EnclosureNumber = EnclosureNumber;
            this.TaskDateTime = TaskDateTime;
            this.EstimatedDuration = EstimatedDuration;
            this.Status = Status;
            this.Species = Species;
            this.Animal = Animal;
            this.assignedEmployees = new List<Employee>();
        }

        //task where only specie is specified, no specific animal selected
        public ZooTask(int ID, string Name, string Description, DateTime TaskDateTime, int EstimatedDuration, string Species) 
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.TaskDateTime = TaskDateTime;
            this.EstimatedDuration = EstimatedDuration;
            this.Status = "Not started";
            this.Species = Species;
            this.assignedEmployees = new List<Employee>();
        }

        public void AssignEmployee(Employee employee)
        {
            assignedEmployees.Add(employee);
        }

        public Employee[] GetAssignedEmployees()
        {
            return assignedEmployees.ToArray();
        }
        public Employee GetAssignedEmployee(int id)
        {
            Employee foundCareTaker;
            foreach (Employee caretaker in assignedEmployees)
            {
                if (caretaker.ID == id)
                {
                    foundCareTaker = caretaker;
                    return foundCareTaker;
                }
            }
            return null;
        }
    }
}
