using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Employee
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
        public ROLE Role { get; set; }

        public Employee()
        {

        }

        //read from database
        public Employee(int id, string firstName, string lastName, DateTime birthDate, string personGender, string phone, string address, string password, string email, ROLE role)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            PersonGender = personGender;
            Address = address;
            Phone = phone;
            Password = password;
            Email = email;
            Role = role;
        }
        //write to database
        public Employee(string firstName, string lastName, DateTime birthDate, string personGender, string phone, string address, string password, string email, ROLE role)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            PersonGender = personGender;
            Address = address;
            Phone = phone;
            Password = password;
            Email = email;
            Role = role;
        }

        public override string ToString()
        {
            return $"{FirstName + " " + LastName}";
        }
    }
}
