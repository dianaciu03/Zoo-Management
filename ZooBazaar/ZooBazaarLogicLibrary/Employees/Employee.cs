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
        public string PersonGender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int HoursPerWeek { get; set; }
        protected Employee(int ID, string FirstName, string LastName, DateTime BirthDate, string PersonGender, string Address, string Phone, string Password, string Email, int HoursPerWeek)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.PersonGender = PersonGender;
            this.Address = Address;
            this.Phone = Phone;
            this.Password = Password;
            this.Email = Email;
            this.HoursPerWeek = HoursPerWeek;
        }

        public virtual string GetRole()
        {
            return this.GetType().Name;
        }
    }
}
