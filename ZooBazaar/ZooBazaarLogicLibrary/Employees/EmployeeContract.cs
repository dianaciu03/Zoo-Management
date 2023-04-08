using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary.Employees
{
    public class EmployeeContract
    {
        string contractType;
        DateTime contractStartDate;
        DateTime? contractEndDate;
        int hoursPerWeek;
        float salary;

        public EmployeeContract(string contractType,DateTime contractStartDate,DateTime? contractEndDate, int hoursPerWeek, float salary)    
        {
            this.contractStartDate = contractStartDate;
            this.contractEndDate = contractEndDate;
            this.contractType= contractType;
            this.hoursPerWeek = hoursPerWeek;
            this.salary = salary;
        }

    }
}
