using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class ScheduleManagement
    {
        ShiftRepository shiftRepo = new ShiftRepository();
        IEmployeeManagement employeeManagement = new EmployeeManagement(new EmployeeRepository());
        public ScheduleManagement() { }

        public Shift[] GetShifts()
        {
            List<Shift> shifts = new List<Shift>();
            foreach (ShiftDTO shiftDTO in shiftRepo.GetAllShifts())
            {
                shifts.Add(new Shift(employeeManagement.GetEmployeeById(shiftDTO.EmployeeId), shiftDTO.ShiftTime));
            }
            return shifts.ToArray();
        }

        public Shift[] GetShifts(DateTime date, out Employee[] employees)
        {
            List<Shift> shifts = new List<Shift>();
            List<Employee> employeesList = new List<Employee>();
            foreach (ShiftDTO shiftDTO in shiftRepo.GetAllShifts(date))
            {
                shifts.Add(new Shift(employeeManagement.GetEmployeeById(shiftDTO.EmployeeId), shiftDTO.ShiftTime));
                Employee employee = employeeManagement.GetEmployeeById(shiftDTO.EmployeeId);
                employeesList.Add(employee);
            }
            employees = employeesList.Distinct().ToArray();
            return shifts.ToArray();
        }

        public Employee[] GetAvailableEmp(DateTime date)
        {
            List<Employee> employeesList = new List<Employee>();
            foreach (int employeeId in shiftRepo.GetShiftEmployees(date))
            {
                Employee employee = employeeManagement.GetEmployeeById(employeeId);
                employeesList.Add(employee);
            }
            return employeesList.ToArray();
        }

        public bool AddShifts(Shift[] shifts, DateTime startDate, DateTime endDate)
        {
            if (shiftRepo.GetShiftsWithinRange(startDate, endDate).Count() > 0)
                return false;
            
            foreach (Shift shift in shifts)
            {
                ShiftDTO shiftDto = new ShiftDTO()
                {
                    EmployeeId = shift.Employee.ID,
                    ShiftTime = shift.ShiftTime
                };
                shiftRepo.AddShift(shiftDto);
            }
            return true;
        }

        public Shift[] GetShiftsInRange(DateTime startDate, DateTime endDate)
        {
            List<Shift> foundShifts = new List<Shift>();
            foreach (ShiftDTO shiftdto in shiftRepo.GetShiftsWithinRange(startDate, endDate))
            {
                Shift shift = new Shift(
                    shiftdto.ShiftId,
                    employeeManagement.GetEmployeeById(shiftdto.EmployeeId),
                    shiftdto.ShiftTime
                );
                foundShifts.Add(shift);
            }
            return foundShifts.ToArray();
        }

        public Shift[] GetShiftsByCaretaker(int careTakerId)
        {
            List<Shift> employeeShifts = new List<Shift>();
            foreach(ShiftDTO shiftDto in shiftRepo.GetAllShifts().Where(x => x.EmployeeId == careTakerId))
            {
                employeeShifts.Add(new Shift(shiftDto.ShiftId, employeeManagement.GetEmployeeById(shiftDto.EmployeeId), shiftDto.ShiftTime));
            }
            return employeeShifts.ToArray();
        }

        public void DeleteShiftsWhitinRange(DateTime start, DateTime end)
        {
            shiftRepo.DeleteShiftsWithinRange(start, end);
        }
    }
}
