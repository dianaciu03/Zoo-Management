using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public GENDER PersonGender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Employee(int ID, string FirstName, string LastName, GENDER PersonGender, string Address, string Password, string Email)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PersonGender = PersonGender;
            this.Address = Address;
            this.Password = Password;
            this.Email = Email;
        }
    }
}
