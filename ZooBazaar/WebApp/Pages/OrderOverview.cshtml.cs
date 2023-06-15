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
                TotalPriceAfterDiscount = order.TotalPriceAfterDiscount;
                DiscountCode = order.DiscountCodeApplied;
            }
        }

        public IActionResult OnPostCheckout()
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

        public IActionResult OnPostValidateDiscount()
        {
            var orderJson = Request.Cookies["OrderCookie"];
            if (orderJson != null)
            {
                TicketOrder order = JsonSerializer.Deserialize<TicketOrder>(orderJson);
                order.CalculateTotalPrice();
                Order = order;
                TotalPriceAfterDiscount = order.TotalPriceAfterDiscount;
            }
            if (DiscountCode == null || !Order.CalculateTotalPriceWithDiscount(DiscountCode))
            {
                ModelState.AddModelError(string.Empty, "Invalid discount code!");
                return Page();
            }
            else
            {
                Order.DiscountCodeApplied = DiscountCode;
                Order.CalculateTotalPriceWithDiscount(DiscountCode);
                
                var updatedOrderJson = JsonSerializer.Serialize(Order);
                // Create a new cookie with the serialized order data
                var cookieOptions = new CookieOptions
                {
                    Expires = DateTime.Now.AddMinutes(30) // Set the expiration date for the cookie
                };
                Response.Cookies.Append("OrderCookie", updatedOrderJson, cookieOptions);
            }

            

            return RedirectToPage();
        }
    }
}
