using BusinessLogic.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IContractManagement
    {
        void UpdateContract(EmployeeContract contract, int employeeId);
    }
}
