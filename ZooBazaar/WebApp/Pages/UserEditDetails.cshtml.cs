using BusinessLogic;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class UserEditDetailsModel : PageModel
    {
        private string sessionKeyId = "_Id";

        private EmployeeManagement employeeManagement;

        public UserEditDetailsModel(IEmployeeRepository employeeRepository)
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

            ID = loggedInEmployee.ID;
            FirstName = loggedInEmployee.FirstName;
            LastName = loggedInEmployee.LastName;
            Email = loggedInEmployee.Email;
            Address = loggedInEmployee.Address;
            BirthDate = loggedInEmployee.BirthDate;
            PersonGender = loggedInEmployee.PersonGender;
            Phone = loggedInEmployee.Phone;
            Password = loggedInEmployee.Password;

            return null;
        }

        [BindProperty]
        public int ID { get; set; }
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public DateTime BirthDate { get; set; }
        [BindProperty]
        public string PersonGender { get; set; }
        [BindProperty]
        public string Phone { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public ROLE Role { get; set; }


        public IActionResult OnPost()
        {
            Employee updateEmployee = new Employee();

            updateEmployee.ID = ID;
            updateEmployee.FirstName = FirstName;
            updateEmployee.LastName = LastName;
            updateEmployee.Email = Email;
            updateEmployee.Address = Address;
            updateEmployee.BirthDate = BirthDate;
            updateEmployee.PersonGender = PersonGender;
            updateEmployee.Phone = Phone;
            updateEmployee.Password = Password;
            updateEmployee.Role = Role;

            employeeManagement.UpdateEmployeeInformation(updateEmployee);
            return new RedirectToPageResult("User");
        }

    }
}
