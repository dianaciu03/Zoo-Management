using DatabaseLogicLibrary;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary.Employees
{
    public static class EmployeeEntityMapping
    {
        public static Employee ToEmployee(this EmployeeDTO employeeDTO)
        {
            return new Employee(employeeDTO.id, employeeDTO.firstName, employeeDTO.lastName, employeeDTO.birthDate, employeeDTO.gender, employeeDTO.phone, employeeDTO.address, employeeDTO.password, employeeDTO.email, (ROLE)Enum.Parse(typeof(ROLE), employeeDTO.role));
        }

        public static EmployeeDTO ToEmployeeDTO(this Employee employee)
        {
            return new EmployeeDTO()
            {
                id = employee.ID,
                firstName = employee.FirstName,
                lastName = employee.LastName,
                birthDate = employee.BirthDate,
                gender = employee.PersonGender,
                phone = employee.Phone,
                address = employee.Address,
                password = employee.Password,
                email = employee.Email,
                role = employee.Role.ToString()
            };
        }
    }
}
