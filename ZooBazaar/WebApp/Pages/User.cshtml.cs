using BusinessLogic;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class UserModel : PageModel
    {
        private const string SessionKeyEmail = "_Email";

        private EmployeeManagement employeeManagement;

        public UserModel(IEmployeeRepository employeeRepository)
        {
            this.employeeManagement = new EmployeeManagement(employeeRepository);
        }

        public IActionResult? OnGet()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyEmail)))
            {
                return new RedirectToPageResult("Login");
            }
            Employee loggedInEmployee = employeeManagement.GetEmployeeByEmail(HttpContext.Session.GetString(SessionKeyEmail));

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
