using BusinessLogic.Employees;

namespace BusinessLogic
{
    public interface IEmployeeManagement
    {
        void AddNewEmployee(Employee employee, EmployeeContract contract, EmergencyContact contact);
        Employee GetEmployeeByEmail(string email);
        Employee[] GetEmployees();
    }
}