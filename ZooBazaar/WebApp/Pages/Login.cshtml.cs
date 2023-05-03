using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using BusinessLogic;
using DataAccess;

namespace WebApp.Pages
{
    public class LoginModel : PageModel
    {
        private const string SessionKeyEmail = "_Email";
        IEmployeeManagement employeeManagement;

        public LoginModel(IEmployeeRepository employeeRepository)
        {
            this.employeeManagement = new EmployeeManagement(employeeRepository);
        }

        public void OnGet()
        {
            //if somone is already logged in redirect to the user page
        }

        [BindProperty, StringLength(40, ErrorMessage = "You must provide a user name with a miminum length of 1", MinimumLength = 1)]
        public string UserName { get; set; }
        [BindProperty, StringLength(40, ErrorMessage = "You must provide a password with a miminum length of 1", MinimumLength = 1)]
        public string Password { get; set; }

        public IActionResult? OnPost()
        {
            Employee logEmployee = employeeManagement.GetEmployeeByEmail(UserName);
            if (logEmployee.Password == Password)
            {
                HttpContext.Session.SetString(SessionKeyEmail, logEmployee.ID.ToString());
                return new RedirectToPageResult("User");
            }

            return null;
        }
    }
}

