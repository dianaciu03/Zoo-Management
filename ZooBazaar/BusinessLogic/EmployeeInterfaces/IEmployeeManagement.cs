using BusinessLogic.Employees;
using DataAccess;

namespace BusinessLogic
{
    public interface IEmployeeManagement
    {
        void AddNewEmployee(Employee employee, EmployeeContract contract, EmergencyContact contact);
        Employee GetEmployeeByEmail(string email);
        Employee? GetEmployeeById(int id);
        Employee[] GetEmployees(out int[] ints);
        CaretakerWithHours[] GetCareTakers();
        public List<Employee> SearchForEmployee(string firstName, string lastname, int weeklyHours, string employeeType, out int[] ints);
        public void UpdateEmployeeInformation(Employee employee);
        public EmployeeContract GetContractById(int id);
        public void AddHoliday(int employeeId, DateTime startDate, DateTime endDate);
    }
}