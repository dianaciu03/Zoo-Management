using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary.Animals
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

        public Transfer(string zooName, string zooAddress, string description, DateTime startDate, DateTime endDate, Animal animal, string zooPhone)
        {
            this.ZooName = zooName;
            this.ZooAddress = zooAddress;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Animal = animal;
            this.ZooPhone = zooPhone;
        }

        public Transfer(int id, string zooName, string zooAddress, string description, DateTime startDate, DateTime endDate, Animal animal, string zooPhone)
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
    }
}
