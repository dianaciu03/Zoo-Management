using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeStandard;
using Spire.Barcode;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLogic.Tickets
{
    public class BarcodeCreator
    {
        public string CreateBarcode(string barcodeString)
        {
            ImageConverter converter = new ImageConverter();

            string temp = "";
            BarcodeSettings bs = new BarcodeSettings();
            bs.Type = BarCodeType.EAN13;
            bs.Data =   barcodeString;
            BarCodeGenerator bg = new BarCodeGenerator(bs);

            var image = bg.GenerateImage();
            byte[] bytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
            temp = Convert.ToBase64String(bytes);
            return temp;
        }
    }
}
