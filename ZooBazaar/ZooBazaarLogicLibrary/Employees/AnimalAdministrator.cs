﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public class AnimalAdministrator:Administrator
    {

        public AnimalAdministrator(int ID, string FirstName, string LastName, DateTime BirthDate, string PersonGender, string Address, string Phone, string Password, string Email)
            :base(ID,FirstName,LastName,BirthDate,PersonGender,Address,Phone,Password,Email)
        { 
           
        }
        
    }
}
