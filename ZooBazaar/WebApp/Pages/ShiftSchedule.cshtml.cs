using BusinessLogic;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApp.Pages
{
    public class ShiftSchedule : PageModel
    {
        private string sessionKeyId = "_Id";

        private EmployeeManagement employeeManagement;

        public ShiftSchedule(IEmployeeRepository employeeRepository)
        {
            this.employeeManagement = new EmployeeManagement(employeeRepository);
            scheduleManagement = new ScheduleManagement();
            taskManagement = new TaskManagement();
        }

        public IActionResult? OnGet()
        {
            HttpContext.Session.SetInt32("WeekCounter", 0);

            if (string.IsNullOrEmpty(HttpContext.Session.GetString(sessionKeyId)))
            {
                return new RedirectToPageResult("Login");
            }
            Employee? loggedInEmployee = employeeManagement.GetEmployeeById(Convert.ToInt32(HttpContext.Session.GetString(sessionKeyId)));

            FirstName = loggedInEmployee.FirstName;
            LastName = loggedInEmployee.LastName;
            Email = loggedInEmployee.Email;
            Address = loggedInEmployee.Address;
            ID = loggedInEmployee.ID;

            //DateTime.Today.AddDays(-dayOfWeek + 8) && task.TaskDateTime < DateTime.Today.AddDays(14 - dayOfWeek)
            DayOfWeek = (int)DateTime.Today.DayOfWeek;
            List<Shift> tempShifts = scheduleManagement.GetShiftsByCaretaker(ID).Where(x => x.ShiftTime.Date < DateTime.Today.AddDays(14 - DayOfWeek) && x.ShiftTime.Date >= DateTime.Today.AddDays(-DayOfWeek + 8)).ToList();
            Tasks = taskManagement.GetTasksByCaretaker(ID).Where(x => x.TaskDateTime.Date < DateTime.Today.AddDays(14 - DayOfWeek) && x.TaskDateTime.Date >= DateTime.Today.AddDays(-DayOfWeek + 8)).ToList();
            Shifts = tempShifts.OrderBy(t => t.ShiftTime).ToList();

            return Page();
        }

        public IActionResult OnPostDown()
        {
            DayOfWeek = (int)DateTime.Today.DayOfWeek;
            WeekCounter = (int)HttpContext.Session.GetInt32("WeekCounter")!;

            Employee? loggedInEmployee = employeeManagement.GetEmployeeById(Convert.ToInt32(HttpContext.Session.GetString(sessionKeyId)));

            FirstName = loggedInEmployee.FirstName;
            LastName = loggedInEmployee.LastName;
            Email = loggedInEmployee.Email;
            Address = loggedInEmployee.Address;
            ID = loggedInEmployee.ID;

            WeekCounter--;

            int dayOfWeek = DayOfWeek + (7 * WeekCounter);
            HttpContext.Session.SetInt32("WeekCounter", WeekCounter);
            List<Shift> tempShifts = scheduleManagement.GetShiftsByCaretaker(ID).Where(x => x.ShiftTime.Date < DateTime.Today.AddDays(14 - dayOfWeek) && x.ShiftTime.Date >= DateTime.Today.AddDays(-dayOfWeek + 8)).ToList();
            Tasks = taskManagement.GetTasksByCaretaker(ID).Where(x => x.TaskDateTime.Date < DateTime.Today.AddDays(14 - dayOfWeek) && x.TaskDateTime.Date >= DateTime.Today.AddDays(-dayOfWeek + 8)).ToList();
            Shifts = tempShifts.OrderBy(t => t.ShiftTime).ToList();
            return null;
        }
        
        public IActionResult OnPostUp()
        {
            DayOfWeek = (int)DateTime.Today.DayOfWeek;

            WeekCounter = (int)HttpContext.Session.GetInt32("WeekCounter")!;

            Employee? loggedInEmployee = employeeManagement.GetEmployeeById(Convert.ToInt32(HttpContext.Session.GetString(sessionKeyId)));

            FirstName = loggedInEmployee.FirstName;
            LastName = loggedInEmployee.LastName;
            Email = loggedInEmployee.Email;
            Address = loggedInEmployee.Address;
            ID = loggedInEmployee.ID;

            WeekCounter++;

            int dayOfWeek = DayOfWeek + (7 * WeekCounter);
            HttpContext.Session.SetInt32("WeekCounter", WeekCounter);
            List<Shift> tempShifts = scheduleManagement.GetShiftsByCaretaker(ID).Where(x => x.ShiftTime.Date < DateTime.Today.AddDays(14 - dayOfWeek) && x.ShiftTime.Date >= DateTime.Today.AddDays(-dayOfWeek + 8)).ToList();
            Tasks = taskManagement.GetTasksByCaretaker(ID).Where(x => x.TaskDateTime.Date < DateTime.Today.AddDays(14 - dayOfWeek) && x.TaskDateTime.Date >= DateTime.Today.AddDays(-dayOfWeek + 8)).ToList();
            Shifts = tempShifts.OrderBy(t => t.ShiftTime).ToList();
            return null;
        }

        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public int ID { get; set; }
        [BindProperty]
        public List<Shift> Shifts { get; set; }
        public List<ZooTask> Tasks { get; set; }
        public int WeekCounter { get; set; }
        public int DayOfWeek { get; set; }
        public ScheduleManagement scheduleManagement { get; set; }
        public TaskManagement taskManagement { get; set; }
    }
}
