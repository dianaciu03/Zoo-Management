using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public struct ContractDTO
    {
        public DateTime startDate;
        public DateTime? endDate;
        public int hoursPerWeek;
        public decimal salary;
        public int employeeId;
    }
}
