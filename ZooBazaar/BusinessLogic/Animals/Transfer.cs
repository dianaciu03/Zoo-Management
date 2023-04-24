using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Animals
{
    public class Transfer
    {
        public int TransferId { get; set; }

        public string ZooPhone { get; set; }

        public string ZooName { get; set; }

        public string ZooAddress { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Animal Animal { get; set; }
        public int AnimalId { get; set; }

        public Transfer(string zooName, string zooAddress, string zooPhone, string description, DateTime startDate, DateTime endDate)
        {
            this.ZooName = zooName;
            this.ZooAddress = zooAddress;
            this.ZooPhone = zooPhone;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public Transfer(int id, string zooName, string zooAddress, string zooPhone, string description, DateTime startDate, DateTime endDate, Animal animal)
        {
            this.TransferId = id;
            this.ZooName = zooName;
            this.ZooAddress = zooAddress;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Animal = animal;
            this.ZooPhone = zooPhone;
        }

        public Transfer(int id, string zooName, string zooAddress, string zooPhone, string description, DateTime startDate, DateTime endDate)
        {
            this.TransferId = id;
            this.ZooName = zooName;
            this.ZooAddress = zooAddress;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ZooPhone = zooPhone;
        }
    }
}
