using DataAccess;
using DataAccess.DTOs;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Employees
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

        public static EmployeeContract ToEmployeeContract(this ContractDTO contractDTO)
        {
            return new EmployeeContract(contractDTO.startDate,contractDTO.endDate,contractDTO.hoursPerWeek,Convert.ToDouble(contractDTO.salary));
        }
        
        public static ContractDTO ToContractDTO(this EmployeeContract employeeContract, int id)
        {
            return new ContractDTO()
            {
                startDate = employeeContract.ContractStartDate,
                endDate = employeeContract.ContractEndDate,
                salary = Convert.ToDecimal(employeeContract.Salary),
                hoursPerWeek = employeeContract.HoursPerWeek,
                employeeId = id
            };
        }

        public static EmergencyContact ToEmergencyContact(this EmergencyContactDTO emergencyContactDTO)
        {
            return new EmergencyContact(emergencyContactDTO.firstName,emergencyContactDTO.lastName,emergencyContactDTO.phone,emergencyContactDTO.relationship);
        }

        public static EmergencyContactDTO ToEmergencyContactDTO(this EmergencyContact employeeEmergencyContact,int id)
        {
            return new EmergencyContactDTO()
            {
                firstName = employeeEmergencyContact.FirstName,
                lastName = employeeEmergencyContact.LastName,
                phone = employeeEmergencyContact.Phone,
                relationship = employeeEmergencyContact.Relationship,
                employeeId = id
            };
        }
    }
}
