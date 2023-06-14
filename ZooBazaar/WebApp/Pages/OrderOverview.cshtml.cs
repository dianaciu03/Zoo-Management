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

        [BindProperty]
        public string DiscountCode { get; set; }

        [BindProperty]
        public decimal TotalPriceAfterDiscount { get; set; }

        public void OnGet()
        {
            if (TempData.ContainsKey("Order"))
            {
                TicketOrder order = JsonSerializer.Deserialize<TicketOrder>(TempData["Order"].ToString())!;
                order.CalculateTotalPrice();
                Order = order;
                TempData["Order"] = JsonSerializer.Serialize(order);
            }
        }

        public IActionResult OnPostCheckout()
        {
            if (TempData.ContainsKey("Order"))
            {
                TicketOrder order = JsonSerializer.Deserialize<TicketOrder>(TempData["Order"].ToString())!;
                order.CalculateTotalPrice();
                Order = order;
            }
            string paymentMethod = Request.Form["paymentMethod"];
            Order.PaymentMethod = paymentMethod;

            TicketManagement tm = new TicketManagement();
            TicketOrder newOrder = tm.AddOrder(Order);
            
            TempData["Order"] = JsonSerializer.Serialize(newOrder);
            return RedirectToPage("ConfirmedOrder");
        }

        public IActionResult OnPostValidateDiscount()
        {
            //Cannot user Order property bcs it's null idk why it's not binded properly tf
            //This method works but on return the tickets go *spook* not there anymore idk why 
            TicketOrder order = JsonSerializer.Deserialize<TicketOrder>(TempData["Order"].ToString())!;
            TotalPriceAfterDiscount =order.CalculateTotalPriceWithDiscount(DiscountCode);
            Order.DiscountCodeApplied = DiscountCode;
            return Page();
        }
    }
}
