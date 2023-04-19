using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CareTaker : Employee
    {
        public CareTaker(int ID, string FirstName, string LastName, DateTime BirthDate, string PersonGender, string Address, string Phone, string Password, string Email, int HoursPerWeek):
            base(ID, FirstName, LastName, BirthDate, PersonGender, Address, Phone, Password, Email, HoursPerWeek)
        {
        }

        public override string GetRole()
        {
            return this.GetType().Name;
        }
    }
}
