using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShiftDTO
    {
        public int ShiftId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ShiftTime { get; set; }
    }
}
