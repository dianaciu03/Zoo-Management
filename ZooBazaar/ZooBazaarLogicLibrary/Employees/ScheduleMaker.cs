using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public class ScheduleMaker : Employee
    {
        public ScheduleMaker(int ID, string FirstName, string LastName, DateTime BirthDate, string PersonGender, string Address, string Phone, string Password, string Email) : base(ID, FirstName, LastName, BirthDate, PersonGender, Phone, Address, Password, Email)
        {

        }
        public ScheduleMaker(string FirstName, string LastName, DateTime BirthDate, string PersonGender, string Address, string Phone, string Password, string Email) : base(FirstName, LastName, BirthDate, PersonGender, Phone, Address, Password, Email)
        {

        }
        public override string GetRole()
        {
            return this.GetType().Name;
        }
    }
}
