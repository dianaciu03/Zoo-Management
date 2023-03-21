using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazaarLogicLibrary
{
    public class FormDataValidator
    {
        public FormDataValidator() { }
        //Checks if string contains any int, if it contains int return false
        public bool IsValidStringOnly(string name)
        {
            if (name.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        //Checks if the dob of animal is in the past(any time in the past), returns true if valid age
        public bool IsValidDateOfBirthAnimal(DateTime dateOfBirth)
        {
            if (dateOfBirth <= DateTime.Now)
            {
                return true;
            }
            return false;
        }

        public bool IsValidAnimalTransferStartDate(DateTime startDate)
        {
            if (startDate <= DateTime.Now)
            {
                return true;
            }
            return false;
        }

        public bool IsValidAnimalTransferEndDate(DateTime endDate)
        {
            if (endDate >= DateTime.Now)
            {
                return true;
            }
            return false;
        }

        //Checks if the employee is at least 16yo, returns true if dob is 16 or older
        public bool IsValidDateOfBirthEmployee(DateTime dateOfBirth)
        {
            if (DateTime.Now.Year - dateOfBirth.Year >= 16)
            {
                return true;
            }
            return false;
        }

        //Checks if string is int (only), if string is int return true
        public bool IsValidIntOnly(string number)
        {
            try
            {
                Convert.ToInt64(number);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Checks if certain fields are empty or if some fields are chars only or ints only(phoneNumber)
        public bool ValidateEmployeeFields(string firstName, string lastName, string email,
            string phoneNumber, string password, string address,string birthDay)
        {
            if (!IsValidStringOnly(firstName) || string.IsNullOrEmpty(firstName))
                return false;
            
            if (!IsValidStringOnly(lastName) || string.IsNullOrEmpty(lastName))
                return false;

            if(string.IsNullOrEmpty(email))
                return false;
            if (string.IsNullOrEmpty(phoneNumber) || !IsValidIntOnly(phoneNumber))
                return false;
            if(string.IsNullOrEmpty(password))
                return false;
            if (string.IsNullOrEmpty(address))
                return false;
           // Converting from string to DateTime
            DateTime myDateTimeVariable;
            // this just gets the time from the masked tbx, idk why it takes so many arguments, ask CHATGPT
            myDateTimeVariable = DateTime.ParseExact(birthDay,"MM/dd/yyyy", CultureInfo.InvariantCulture);

            /*if (!IsValidDateOfBirthEmployee(myDateTimeVariable))
                return false;*/

            return true;
        }

        public bool IsValidTransfer(string name, string adress, string description, DateTime startDate, DateTime endDate)
        {
            if (IsValidStringOnly(name) && !String.IsNullOrEmpty(adress) && !String.IsNullOrEmpty(description) && IsValidAnimalTransferStartDate(startDate) && IsValidAnimalTransferEndDate(endDate))
                return true;
            else
                return false;
        }
    }
}
