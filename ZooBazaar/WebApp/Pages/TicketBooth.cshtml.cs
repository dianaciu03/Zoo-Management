using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class TicketBoothModel : PageModel
    {
        [BindProperty]
        public int AdultTicket { get; set; }

        [BindProperty]
        public int KidTicket { get; set; }

        [BindProperty]
        public int ToddlerTicket { get; set; }

        [BindProperty]
        public string DiscountCode { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            return Page();
        }
    }
}
