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

        public IActionResult OnPost()
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

        //public IActionResult OnPostValidateDiscount()
        //{
            //methods to get the new price after the discount code is validated and applied
            //dabo e treaba ta
            //Order.DiscountCodeApplied = DiscountCode
            //Order.TotalPrice = newTotalPrice
        //}
    }
}
