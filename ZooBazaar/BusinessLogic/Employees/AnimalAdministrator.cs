using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AnimalAdministrator:Administrator
    {

        public AnimalAdministrator(int ID, string FirstName, string LastName, DateTime BirthDate, string PersonGender, string Address, string Phone, string Password, string Email, int HoursPerWeek)
            :base(ID,FirstName,LastName,BirthDate,PersonGender,Address,Phone,Password,Email,40)
        { 
           
        }

        public override string GetRole()
        {
            return this.GetType().Name;
        }
    }
}
