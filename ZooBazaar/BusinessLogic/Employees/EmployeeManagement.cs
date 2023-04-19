using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessLogic.Employees;

namespace BusinessLogic
{
    public class EmployeeManagement : IEmployeeManagement
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();

        public EmployeeManagement()
        {
        }
        public void AddNewEmployee(Employee employee)
        {
            EmployeeDTO employeeDto = new EmployeeDTO
            {
                id = employee.ID,
                firstName = employee.FirstName,
                lastName = employee.LastName,
                birthDate = employee.BirthDate,
                gender = employee.PersonGender,
                address = employee.Address,
                phone = employee.Phone,
                password = employee.Password,
                email = employee.Email,
                role = employee.Role.ToString()
            };
            employeeRepository.AddUpdateEmployee(employeeDto);
        }
        public Employee[] GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            foreach (EmployeeDTO employeeDto in employeeRepository.GetAllEmployees())
            {
                Employee employee = employeeDto.ToEmployee();
                employees.Add(employee);
            }
            return employees.ToArray();
        }

        public Employee GetEmployeeByEmail(string email)
        {
            EmployeeDTO? employeeDto = null;
            if (employeeRepository.GetEmployeeByEmail(email) != null)
                employeeDto = employeeRepository.GetEmployeeByEmail(email);
            if (employeeDto == null)
                return null;
            Employee employee = ((EmployeeDTO)employeeDto).ToEmployee();

            return employee;
        }

        /*public List<Employee> GetSearchedEmployees(string firstName, string lastName, string contractType, string role)
        {
            List<Employee> searchedEmployees = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
                if (contractType == string.Empty)
                {
                    if ((employee.FirstName.ToLower().Contains(firstName.ToLower()) || String.IsNullOrEmpty(firstName)) &&
                        (employee.LastName.ToLower().Contains(lastName.ToLower()) || String.IsNullOrEmpty(lastName)) &&
                        (employee.GetRole() == role || String.IsNullOrEmpty(role.ToString())))
                    {
                        searchedEmployees.Add(employee);
                    }
                }
                else
                {
                    if ((employee.FirstName.ToLower().Contains(firstName.ToLower()) || String.IsNullOrEmpty(firstName)) &&
                        (employee.LastName.ToLower().Contains(lastName.ToLower()) || String.IsNullOrEmpty(lastName)) &&
                        (employee.GetRole() == role.ToString() || String.IsNullOrEmpty(role.ToString())) &&
                        (employee.HoursPerWeek == 40)) //needs fixing when we add contracts
                    {
                        searchedEmployees.Add(employee);
                    }
                }
            }
            return searchedEmployees;
        }*/
    }
}
