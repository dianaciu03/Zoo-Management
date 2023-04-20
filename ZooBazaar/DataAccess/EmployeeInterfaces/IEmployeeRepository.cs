using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IEmployeeRepository
    {
        List<EmployeeDTO> GetAllEmployees();
        public void AddUpdateEmployee(EmployeeDTO employee, ContractDTO contract, EmergencyContactDTO emergencyContact);
        public List<EmployeeDTO> SearchForEmployee(string firstName, string lastname, int weeklyHours, string employeeType);
        public EmployeeDTO? GetEmployeeByEmail(string email);

    }
}
