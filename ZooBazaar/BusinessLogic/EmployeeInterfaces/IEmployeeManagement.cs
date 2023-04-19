namespace BusinessLogic
{
    public interface IEmployeeManagement
    {
        void AddNewEmployee(Employee employee);
        Employee GetEmployeeByEmail(string email);
        Employee[] GetEmployees();
    }
}