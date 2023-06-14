using BusinessLogic.Tickets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Sockets;

namespace WebApp.Pages
{
    public class ConfirmedOrderModel : PageModel
    {
        BarcodeCreator barcodeCreator;
        public List<Ticket> Tickets { get; set; }

        public void OnGet()
        {
            barcodeCreator = new BarcodeCreator();
            Tickets = new List<Ticket>();

            Tickets.Add(new Ticket(
                "Adult",
                (decimal)20.24,
                2023061400001));
        }

        public string CreateBarcode(string barcode)
        {
            return barcodeCreator.CreateBarcode(barcode);
        }
    }
}
