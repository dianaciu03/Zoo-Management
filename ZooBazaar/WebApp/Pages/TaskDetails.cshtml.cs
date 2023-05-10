using BusinessLogic;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace WebApp.Pages
{
    public class TaskDetailsModel : PageModel
    {
        private string sessionKeyId = "_Id";

        private EmployeeManagement employeeManagement;

        public TaskDetailsModel(IEmployeeRepository employeeRepository)
        {
            this.employeeManagement = new EmployeeManagement(employeeRepository);
            taskManagement = new TaskManagement();
        }

        public IActionResult? OnGet(int id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(sessionKeyId)))
            {
                return new RedirectToPageResult("Login");
            }
            Task = taskManagement.GetTask(id);
            return Page();
        }
        [BindProperty]
        public ZooTask Task { get; set; }
        [BindProperty]
        public TaskManagement taskManagement { get; set; }
    }
}
