using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLibrary
{
    public class EmployeeDTO
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string PersonGender { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public int HoursPerWeek { get; private set; }
        public string EmployeeType { get; private set; }

        public EmployeeDTO(int ID, string FirstName, string LastName, DateTime BirthDate, string PersonGender, string Address, string Phone, string Password, string Email, int HoursPerWeek, string employeeType)
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
            this.EmployeeType = employeeType;
        }
    }
}
