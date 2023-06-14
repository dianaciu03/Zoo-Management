using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeStandard;

namespace BusinessLogic.Tickets
{
    public class BarcodeCreator
    {
        public string CreateBarcode(string barcodeString)
        {
            //var barcode = BarcodeWriter.CreateBarcode(barcodeString, BarcodeEncoding.Code128/*Encoding is the type of barcode it is*/);
            //barcode.ResizeTo(400, 100);

            //return Convert.ToBase64String(barcode.ToImage().GetBytes());

            Barcode barcode1 = new Barcode();
            barcode1.Encode(BarcodeStandard.Type.Ean13, barcodeString, 400, 100);
            byte[] bytes = barcode1.GetImageData(SaveTypes.Png);




            return Convert.ToBase64String(bytes);


        }
    }
}
