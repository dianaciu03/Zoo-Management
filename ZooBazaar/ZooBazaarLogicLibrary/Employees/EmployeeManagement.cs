﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLibrary;

namespace ZooBazaarLogicLibrary
{
    public class EmployeeManagement
    {
        DatabaseEmployeeHelper employeeRepository = new DatabaseEmployeeHelper();
        private List<Employee> employeeList;

        public EmployeeManagement() 
        {
            this.employeeList = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }
        public Employee[] GetEmployees()
        {
            return employeeList.ToArray();
        }

        public Employee GetEmployee(string email, string password)
        {
            foreach (Employee employee in employeeList)
            {
                if (employee.Email == email && employee.Password == password)
                {
                    return employee;
                }
            }
            return null;
        }

        public Employee GetEmployeeByEmail(string email)
        {
            EmployeeDTO employeeDto = employeeRepository.GetEmployeeByEmail(email);
            Employee employee = null;
            switch (employeeDto.EmployeeType) 
            {
                case nameof(HRAdministrator):
                    employee = new HRAdministrator(employeeDto.ID, employeeDto.FirstName, employeeDto.LastName, employeeDto.BirthDate, employeeDto.PersonGender, employeeDto.Address, employeeDto.Phone, employeeDto.Password, employeeDto.Email, employeeDto.HoursPerWeek);
                    break;
                case nameof(AnimalAdministrator):
                    employee = new AnimalAdministrator(employeeDto.ID, employeeDto.FirstName, employeeDto.LastName, employeeDto.BirthDate, employeeDto.PersonGender, employeeDto.Address, employeeDto.Phone, employeeDto.Password, employeeDto.Email, employeeDto.HoursPerWeek);
                    break;
                case nameof(ScheduleMaker):
                    employee = new ScheduleMaker(employeeDto.ID, employeeDto.FirstName, employeeDto.LastName, employeeDto.BirthDate, employeeDto.PersonGender, employeeDto.Address, employeeDto.Phone, employeeDto.Password, employeeDto.Email, employeeDto.HoursPerWeek);
                    break;
                case nameof(ResourcePlanner):
                    employee = new ResourcePlanner(employeeDto.ID, employeeDto.FirstName, employeeDto.LastName, employeeDto.BirthDate, employeeDto.PersonGender, employeeDto.Address, employeeDto.Phone, employeeDto.Password, employeeDto.Email, employeeDto.HoursPerWeek);
                    break;
            }
            return employee;
        }

        public List<Employee> GetSearchedEmployees(string firstName, string lastName, string contractType, string role)
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
        }
    }
}
