namespace ZooBazaarLogicLibrary.Employees
{
    public interface IEmergencyContactManagement
    {
        void AddEmergencyContact(int employeeId);
        EmergencyContact GetContactByEmployee(int employeeId);
    }
}