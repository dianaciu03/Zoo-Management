using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public class AnimalAdministrator:Administrator
    {

        public AnimalAdministrator(int ID, string FirstName, string LastName, DateTime BirthDate, string PersonGender, string Phone, string Address, string Password, string Email)
            :base(ID,FirstName,LastName,BirthDate,PersonGender,Phone,Address,Password,Email)
        { 
           
        }
        public AnimalAdministrator(string FirstName, string LastName, DateTime BirthDate, string PersonGender, string Phone, string Address, string Password, string Email)
            :base(FirstName,LastName,BirthDate,PersonGender,Phone,Address,Password,Email)
        { 
           
        }

        public override string GetRole()
        {
            return this.GetType().Name;
        }
    }
}
