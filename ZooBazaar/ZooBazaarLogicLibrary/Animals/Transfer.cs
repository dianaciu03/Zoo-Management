using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary.Animals
{
    public class Transfer
    {
        public string ZooName { get; set; }

        public string ZooAdress { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Animal Animal { get; set; }

        public Transfer(string zooName, string zooAdress, string description, DateTime startDate, DateTime endDate, Animal animal)
        {
            //this.id = id;
            this.ZooName = zooName;
            this.ZooAdress = zooAdress;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Animal = animal;
        }


    }
}
