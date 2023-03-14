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

        public Employee GetEmployee(string email, string password)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Email == email && employee.Password == password)
                {
                    return employee;
                }
            }
            return null;
        }
    }
}
