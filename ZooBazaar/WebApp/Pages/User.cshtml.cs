using BusinessLogic;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class UserModel : PageModel
    {
        private string sessionKeyId = "_Id";

        private EmployeeManagement employeeManagement;

        public UserModel(IEmployeeRepository employeeRepository)
        {
            this.employeeManagement = new EmployeeManagement(employeeRepository);
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

    }
}
