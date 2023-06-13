using BusinessLogic.Tickets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

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
        public DateTime ValidDate { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            TicketOrder order = new TicketOrder();
            if(AdultTicket + ToddlerTicket + KidTicket >= 20)
            {
                for (int i = 1; i <= AdultTicket; i++)
                {
                    Ticket ticket = new Ticket("Adult", (decimal)24.50, ValidDate);
                    order.AddTicketToOrder(ticket);
                }
                for (int i = 1; i <= KidTicket; i++)
                {
                    Ticket ticket = new Ticket("Kid", (decimal)23, ValidDate);
                    order.AddTicketToOrder(ticket);
                }
                for (int i = 1; i <= ToddlerTicket; i++)
                {
                    Ticket ticket = new Ticket("Toddler", (decimal)0, ValidDate);
                    order.AddTicketToOrder(ticket);
                }
            }
            else
            {
                for (int i = 1; i <= AdultTicket; i++)
                {
                    Ticket ticket = new Ticket("Adult", (decimal)26.50, ValidDate);
                    order.AddTicketToOrder(ticket);
                }
                for (int i = 1; i <= KidTicket; i++)
                {
                    Ticket ticket = new Ticket("Kid", (decimal)24, ValidDate);
                    order.AddTicketToOrder(ticket);
                }
                for (int i = 1; i <= ToddlerTicket; i++)
                {
                    Ticket ticket = new Ticket("Toddler", (decimal)0, ValidDate);
                    order.AddTicketToOrder(ticket);
                }
            }
            TempData["Order"] = JsonSerializer.Serialize(order);
            //needs to refirect to another page with the total amount
            return RedirectToPage("OrderOverview");
        }
    }
}
