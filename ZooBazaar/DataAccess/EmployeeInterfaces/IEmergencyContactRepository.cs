using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IEmergencyContactRepository
    {
        EmergencyContactDTO GetEmergencyContactByID(int id);
        void UpdateEmergencyContact(EmergencyContactDTO emergencyContact);
    }
}
