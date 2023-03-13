using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLibrary.Enums;

namespace ZooBazaarLogicLibrary
{
    public class ScheduleMaker : Employee
    {
        public ScheduleMaker(int ID, string FirstName, string LastName, DateTime BirthDate, GENDER PersonGender, string Address, string Phone, string Password, string Email) : base(ID, FirstName, LastName, BirthDate, PersonGender, Address, Phone, Password, Email, 40)
        {

        }

        public string GetRole()
        {
            return this.GetType().Name;
        }
    }
}
