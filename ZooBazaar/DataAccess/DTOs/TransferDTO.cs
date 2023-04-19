using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class TransferDTO
    {
        public int TransferId { get; private set; }

        public string ZooPhone { get; private set; }

        public string ZooName { get; private set; }

        public string ZooAddress { get; private set; }

        public string Description { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public AnimalDTO Animal { get; set; }

        public TransferDTO(int id, string zooName, string zooAddress, string description, DateTime startDate, DateTime endDate, string zooPhone, AnimalDTO animal)
        {
            this.TransferId = id;
            this.ZooName = zooName;
            this.ZooAddress = zooAddress;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ZooPhone = zooPhone;
            this.Animal = animal;
        }
    }
}
