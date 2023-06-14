using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronBarCode;
using SixLabors.ImageSharp;

namespace BusinessLogic.Tickets
{
    public class BarcodeCreator
    {
        public string CreateBarcode(string barcodeString)
        {
            var barcode = BarcodeWriter.CreateBarcode(barcodeString, BarcodeEncoding.Code128/*Encoding is the type of barcode it is*/);
            barcode.ResizeTo(400, 100);

            return Convert.ToBase64String(barcode.ToImage().GetBytes());
        }
    }
}
