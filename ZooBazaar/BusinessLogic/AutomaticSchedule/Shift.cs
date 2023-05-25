using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Shift
    {
        public Employee Employee { get; set; }
        public DateTime ShiftTime { get; set; }
        public Shift(Employee employee, DateTime shiftTime)
        {
            Employee = employee;
            ShiftTime = shiftTime;
        }
    }
}
