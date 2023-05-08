using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EmployeeInterfaces
{
    public interface IContractRepository
    {
        public void UpdateContract(ContractDTO contract);
    }
}
