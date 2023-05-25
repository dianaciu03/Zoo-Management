using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Shift
    {
        public int ShiftId { get; set; }
        public Employee Employee { get; set; }
        public DateTime ShiftTime { get; set; }
        public Shift(Employee employee, DateTime shiftTime)
        {
            Employee = employee;
            ShiftTime = shiftTime;
        }
        public Shift(int shiftId, Employee employee, DateTime shiftTime)
        {
            ShiftId = shiftId;
            Employee = employee;
            ShiftTime = shiftTime;
        }
    }
}
