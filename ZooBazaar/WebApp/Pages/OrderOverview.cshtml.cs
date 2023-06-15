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
            var orderJson = Request.Cookies["OrderCookie"];
            if (orderJson != null)
            {
                TicketOrder order = JsonSerializer.Deserialize<TicketOrder>(orderJson);
                order.CalculateTotalPrice();
                Order = order;
            }
        }

        public IActionResult OnPost()
        {
            OnGet();
            string paymentMethod = Request.Form["paymentMethod"];
            Order.PaymentMethod = paymentMethod;

            TicketManagement tm = new TicketManagement();
            TicketOrder newOrder = tm.AddOrder(Order);

            var updatedOrderJson = JsonSerializer.Serialize(newOrder);
            // Create a new cookie with the serialized order data
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddMinutes(30) // Set the expiration date for the cookie
            };
            Response.Cookies.Append("OrderCookie", updatedOrderJson, cookieOptions);

            return RedirectToPage("ConfirmedOrder");
        }

        //public IActionResult OnPostValidateDiscount()
        //{
            //methods to get the new price after the discount code is validated and applied
            //dabo e treaba ta
            //Order.DiscountCodeApplied = DiscountCode
            //Order.TotalPrice = newTotalPrice
        //}
    }
}
