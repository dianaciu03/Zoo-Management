using BusinessLogic.Employees;
using DataAccess;

namespace BusinessLogic
{
    public interface IEmployeeManagement
    {
        void AddNewEmployee(Employee employee, EmployeeContract contract, EmergencyContact contact);
        Employee GetEmployeeByEmail(string email);
        Employee[] GetEmployees(out int[] ints);
        public List<Employee> SearchForEmployee(string firstName, string lastname, int weeklyHours, string employeeType, out int[] ints);
    }
}