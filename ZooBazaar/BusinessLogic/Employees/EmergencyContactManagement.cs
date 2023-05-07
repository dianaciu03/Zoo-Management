using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Employees
{
    public class EmergencyContactManagement : IEmergencyContactManagement
    {
        IEmergencyContactRepository _emergencyContactRepository;
        public EmergencyContactManagement(IEmergencyContactRepository em)
        {
            _emergencyContactRepository= em;
        }

        public EmergencyContact GetContactByEmployee(int employeeId)
        {
            return _emergencyContactRepository.GetEmergencyContactByID(employeeId).ToEmergencyContact();
        }

        public void UpdateEmergencyContact(EmergencyContact contact, int id)
        {
            _emergencyContactRepository.UpdateEmergencyContact(contact.ToEmergencyContactDTO(id));
        }
    }
}
