using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BusinessLogic;
using BusinessLogic.Tickets;
using IronBarCode;
using System.Drawing;

namespace WebApp.Pages
{
    public class BarcodeModel : PageModel
    {
        BarcodeCreator barcodeCreator;

        public string Barcode { get; private set; }

        public BarcodeModel() 
        {
            barcodeCreator = new BarcodeCreator();
        }

        public void OnGet()
        {
            byte[] barcode = barcodeCreator.CreateBarcode("123456"/*barcode string goes here*/);
            
            Barcode = Convert.ToBase64String(barcode);
        }
    }
}
