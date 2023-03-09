using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public class EmployeeManagement
    {
        private List<Employee> employees;

        public EmployeeManagement() 
        {
            this.employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public Employee[] GetEmployees()
        {
            return employees.ToArray();
        }
    }
}
