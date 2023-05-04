using BusinessLogic;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace WebApp.Pages
{
    public class ScheduleModel : PageModel
    {
        private string sessionKeyId = "_Id";

        private EmployeeManagement employeeManagement;

        public ScheduleModel(IEmployeeRepository employeeRepository)
        {
            this.employeeManagement = new EmployeeManagement(employeeRepository);
            taskManagement = new TaskManagement();
        }

        public IActionResult? OnGet()
        {
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

            Tasks = taskManagement.GetTasksByCaretaker(ID).ToList();

            return Page();
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
        public List<ZooTask> Tasks { get; set; }

        public TaskManagement taskManagement { get; set; }
    }
}
