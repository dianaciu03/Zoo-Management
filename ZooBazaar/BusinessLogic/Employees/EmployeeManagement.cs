using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessLogic.Employees;
using DataAccess.DTOs;

namespace BusinessLogic
{
    public class EmployeeManagement : IEmployeeManagement
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeManagement(IEmployeeRepository employeeRepository)
        {
            _employeeRepository= employeeRepository;
        }
        public void AddNewEmployee(Employee employee, EmployeeContract contract, EmergencyContact emergencyContact)
        {
            EmployeeDTO employeeDto = new EmployeeDTO
            {
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

            ContractDTO contractDto = new ContractDTO
            {
                startDate = contract.ContractStartDate,
                endDate = contract.ContractEndDate,
                hoursPerWeek = contract.HoursPerWeek,
                salary = contract.Salary
            };

            EmergencyContactDTO contactDto = new EmergencyContactDTO
            {
                firstName = emergencyContact.FirstName,
                lastName = emergencyContact.LastName,
                relationship = emergencyContact.Relationship,
                phone = emergencyContact.Phone,
            };

            _employeeRepository.AddUpdateEmployee(employeeDto, contractDto, contactDto);
        }
        public Employee[] GetEmployees(out int[] ints)
        {
            List<Employee> employees = new List<Employee>();
            List<int> weeklyHours = new List<int>();
            foreach (EmployeeDTO employeeDto in _employeeRepository.GetAllEmployees())
            {
                weeklyHours.Add(employeeDto.hoursPerWeek);
                Employee employee = employeeDto.ToEmployee();
                employees.Add(employee);
            }
            ints = weeklyHours.ToArray();
            return employees.ToArray();
        }

        public Employee GetEmployeeByEmail(string email)
        {
            EmployeeDTO? employeeDto = null;
            if (_employeeRepository.GetEmployeeByEmail(email) != null)
                employeeDto = _employeeRepository.GetEmployeeByEmail(email);
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
