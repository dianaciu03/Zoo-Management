using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public class ScheduleMaker : Employee
    {
        public ScheduleMaker(int ID, string FirstName, string LastName, DateTime BirthDate, string PersonGender, string Address, string Phone, string Password, string Email,int HouersPerWeek) : base(ID, FirstName, LastName, BirthDate, PersonGender, Address, Phone, Password, Email, 40)
        {

        }

        public string GetRole()
        {
            return this.GetType().Name;
        }
    }
}
