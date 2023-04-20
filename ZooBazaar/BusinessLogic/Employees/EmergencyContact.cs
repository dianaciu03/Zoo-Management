using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Employees
{
    public class EmergencyContact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Relationship { get; set; }
        public EmergencyContact(string FirstName, string LastName, string Phone, string Relationship)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Relationship = Relationship;
        }
        public EmergencyContact(int Id, string FirstName, string LastName, string Phone, string Relationship)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Relationship = Relationship;
        }
    }
}
