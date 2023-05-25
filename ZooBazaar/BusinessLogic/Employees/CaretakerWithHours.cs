using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Employees
{
    public class CaretakerWithHours
    {
        public Employee Employee { get; init; }
        public int ContractHours { get; init; }
        public CaretakerWithHours(Employee employee, int contractHours)
        {
            Employee = employee;
            ContractHours = contractHours;
        }
    }
}
