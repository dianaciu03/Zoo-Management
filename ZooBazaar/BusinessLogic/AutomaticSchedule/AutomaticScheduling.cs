﻿using BusinessLogic;
using BusinessLogic.Employees;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AutomaticScheduling
    {
        public AutomaticScheduling()
        {
            
        }
        public Shift[] ScheduleEmployeesForShifts(CaretakerWithHours[] careTakers)
        {
            List<Shift> shifts = new List<Shift>();

            DateTime today = DateTime.Today;
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextMonday = DateTime.Today.AddDays(daysUntilMonday);
            DateTime endOfWeek = nextMonday.AddDays(6);
            DateTime nextShift = nextMonday;
            foreach (CaretakerWithHours careTaker in careTakers)
            {
                int daysPerWeek = careTaker.ContractHours / 8;
                for (int i = 0; i < daysPerWeek; i++)
                {
                    shifts.Add(new Shift(careTaker.Employee, new DateTime(nextShift.Year, nextShift.Month, nextShift.Day, 8, 0, 0)));
                    if (nextShift.DayOfWeek == DayOfWeek.Sunday)
                    {
                        nextShift = nextMonday;
                    }
                    else
                    {
                        nextShift = nextShift.AddDays(1);
                    }
                }
            }
            return shifts.ToArray();
        }
    }
}
