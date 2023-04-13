using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLibrary.DTOs
{
    public struct ContractDTO
    {
        public DateTime startDate;
        public DateTime? endDate;
        public int hoursPerWeek;
        public double salary;
        public int employeeId;
    }
}
