﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public class CareTaker : Employee
    {
        public CareTaker(int ID, string FirstName, string LastName, GENDER PersonGender, string Address, string Password, string Email) :
            base(ID, FirstName, LastName, PersonGender, Address, Password, Email)
        {

        }
        public string GetRole()
        {
            return this.GetType().Name;
        }
    }
}
