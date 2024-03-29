﻿using System;
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
            _employeeRepository = employeeRepository;
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
        public Employee[] GetEmployees(out int[] contractHours)
        {
            List<Employee> employees = new List<Employee>();
            List<int> weeklyHours = new List<int>();
            foreach (EmployeeDTO employeeDto in _employeeRepository.GetAllEmployees())
            {
                weeklyHours.Add(employeeDto.hoursPerWeek);
                Employee employee = employeeDto.ToEmployee();
                employees.Add(employee);
            }
            contractHours = weeklyHours.ToArray();
            return employees.ToArray();
        }
        public CaretakerWithHours[] GetCareTakers()
        {
            List<CaretakerWithHours> careTakers = new List<CaretakerWithHours>();
            foreach (EmployeeDTO employeeDto in _employeeRepository.GetAllCareTakers())
            {
                CaretakerWithHours careTaker = new CaretakerWithHours(employeeDto.ToEmployee(), employeeDto.hoursPerWeek);
                careTakers.Add(careTaker);
            }
            return careTakers.ToArray();
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

        public void AddHoliday(int employeeId, DateTime startDate, DateTime endDate)
        {
            _employeeRepository.AddHoliday(employeeId, startDate, endDate);
        }

        public (List<Employee>,List<DateTime>,List<DateTime>) GetAllEmployeesThatHaveHoliday()
        {
            List<Employee> employees = new List<Employee>();
            List<EmployeeDTO> dtos = new List<EmployeeDTO>();
            List<DateTime> startDates = new List<DateTime>();
            List<DateTime> endDates = new List<DateTime>();
            (dtos, startDates, endDates) = _employeeRepository.GetAllEmployeesThatHaveHolidays();
            foreach ( EmployeeDTO dto in dtos)
            {
                employees.Add(dto.ToEmployee());
            }

            return (employees, startDates, endDates);
        }

        public bool DeleteHoliday(int employeeId, DateTime startDate)
        {
            return _employeeRepository.DeleteHoliday(employeeId, startDate);
        }
    }
}
