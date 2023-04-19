using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Employees
{
    public class EmployeeContract
    {
        public string ContractType { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public int HoursPerWeek { get; set; }
        public double Salary { get; set; }

        public EmployeeContract(DateTime contractStartDate,DateTime? contractEndDate, int hoursPerWeek, float salary)    
        {
            this.ContractStartDate = contractStartDate;
            this.ContractEndDate = contractEndDate;
            this.HoursPerWeek = hoursPerWeek;
            if (hoursPerWeek == 40)
            {
                ContractType = "Full-time";
            }
            else ContractType = "Part-time";
            this.Salary = salary;
        }

    }
}
