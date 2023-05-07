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
                salary = Convert.ToDecimal(contract.Salary)
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
        public Employee? GetEmployeeById(int id)
        {
            EmployeeDTO? employeeDto = null;
            if (_employeeRepository.GetEmployeeById(id) != null)
                employeeDto = _employeeRepository.GetEmployeeById(id);
            if (employeeDto == null)
                return null;
            Employee employee = ((EmployeeDTO)employeeDto).ToEmployee();

            return employee;
        }

        public List<Employee> SearchForEmployee(string firstName, string lastname, int weeklyHours, string employeeType, out int[] ints)
        {
            List<Employee> employees = new List<Employee>();
            List<int> hoursPerWeek = new List<int>();
            foreach (EmployeeDTO employeeDto in _employeeRepository.SearchForEmployee(firstName,lastname,weeklyHours,employeeType))
            {
                hoursPerWeek.Add(employeeDto.hoursPerWeek);
                Employee employee = employeeDto.ToEmployee();
                employees.Add(employee);
            }
            ints = hoursPerWeek.ToArray();
            return employees;
        }

        public void UpdateEmployeeInformation(Employee employee)
        {
            ContractDTO emptyContract= new ContractDTO();
            EmergencyContactDTO emptyContact= new EmergencyContactDTO();
            
            _employeeRepository.AddUpdateEmployee(employee.ToEmployeeDTO(),emptyContract,emptyContact);
        }

        public EmployeeContract GetContractById(int id)
        {
            
           return _employeeRepository.GetContractById(id).ToEmployeeContract();

        }
    }
}
