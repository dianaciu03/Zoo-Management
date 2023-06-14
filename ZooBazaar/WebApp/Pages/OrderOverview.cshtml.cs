using BusinessLogic.Tickets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Text.Json;

namespace WebApp.Pages
{
    public class OrderOverviewModel : PageModel
    {
        [BindProperty]
        public TicketOrder Order { get; set; }

        public void OnGet()
        {
            if (TempData.ContainsKey("Order"))
            {
                TicketOrder order = JsonSerializer.Deserialize<TicketOrder>(TempData["Order"].ToString())!;
                order.CalculateTotalPrice();
                Order = order;

            }
        }

        public IActionResult OnPost()
        {
            //SET THE NEW PRICE
            //ADD THE TICKETS TO DATABASE
            //ADD ORDER TO DATABASE
            //GET ORDER
            //GET TICKETS FROM DATABASE
            //CREATE NEW ORDER OBJECT
            //ADD TICKETS TO NEW ORDER OBJECT (this should have the new total price, ticket barcodes, valid date etc)
            TempData["Order"] = JsonSerializer.Serialize(Order);
            return RedirectToPage("ConfirmedOrder");
        }
    }
}
