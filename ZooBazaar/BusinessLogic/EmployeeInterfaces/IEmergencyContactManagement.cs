namespace BusinessLogic.Employees
{
    public interface IEmergencyContactManagement
    {
        EmergencyContact GetContactByEmployee(int employeeId);
        void UpdateEmergencyContact(EmergencyContact contact, int id);
    }
}