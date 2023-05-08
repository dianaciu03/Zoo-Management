using DataAccess.EmployeeInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Employees
{
    public class ContractManagement : IContractManagement
    {
        IContractRepository _contractRepository;
        public ContractManagement(IContractRepository cr) 
        { 
            _contractRepository= cr;
        }
        public void UpdateContract(EmployeeContract contract, int id)
        {
            _contractRepository.UpdateContract(contract.ToContractDTO(id));
        }
    }
}
