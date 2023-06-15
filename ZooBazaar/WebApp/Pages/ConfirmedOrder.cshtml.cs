using BusinessLogic.Tickets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Sockets;
using System.Text.Json;

namespace WebApp.Pages
{
    public class ConfirmedOrderModel : PageModel
    {
        BarcodeCreator barcodeCreator;

        [BindProperty]
        public TicketOrder Order { get; set; }

        public void OnGet()
        {
            var orderJson = Request.Cookies["OrderCookie"];
            if (orderJson != null)
            {
                TicketOrder order = JsonSerializer.Deserialize<TicketOrder>(orderJson);
                order.CalculateTotalPrice();
                order.CalculateTotalPriceWithDiscount(order.DiscountCodeApplied);
                Order = order;
            }

            barcodeCreator = new BarcodeCreator();
        }

        public string CreateBarcode(string barcode)
        {
            return barcodeCreator.CreateBarcode(barcode);
        }
    }
}
