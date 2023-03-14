using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public class FormDataValidator
    {
        public FormDataValidator() { }
        //Checks if string contains any int, if it contains int return false
        public bool IsValidStringOnly(string name)
        {
            if(name.Any(char.IsDigit)) 
            {
                return false;
            }
            return true;
        }

        //Checks if the dob of animal is in the past(any time in the past), returns true if valid age
        public bool IsValidDateOfBirthAnimal(DateTime dateOfBirth)
        {
            DateTime timeNow = DateTime.Now;
            if (dateOfBirth <= timeNow)
            {
                return true;
            }
            return false;
        }
        //Checks if the employee is at least 16yo, returns true if dob is 16 or older
        public bool IsValidDateOfBirthEmployee(DateTime dateOfBirth)
        {
            DateTime timeNow = DateTime.Now;
            if (dateOfBirth.Year-timeNow.Year >= 16)
            {
                return true;
            }
            return false;
        }

        //Checks if string is int (only), if string its int return true
        public bool IsValidIntOnly(string number)
        {
            try
            {
                Convert.ToInt32(number);
                return true;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
