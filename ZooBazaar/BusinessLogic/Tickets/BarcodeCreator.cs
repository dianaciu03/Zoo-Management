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
        public byte[] CreateBarcode(string barcodeString)
        {
            var barcode = BarcodeWriter.CreateBarcode(barcodeString, BarcodeEncoding.Code128);

            return barcode.ToImage().GetBytes();
        }
    }
}
