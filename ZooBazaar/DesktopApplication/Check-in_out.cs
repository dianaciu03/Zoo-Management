using BusinessLogic.Tickets;
using DataAccess.Tickets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopApplication
{
    public partial class Check_in_out : Form
    {
        TicketManagement ticketManagement;

        public Check_in_out()
        {
            InitializeComponent();

            ticketManagement = new TicketManagement();
            panelInvalidTicket.Hide();
            panelValidTicket.Hide();
        }



        private async void textBoxBarcodeString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != (char)Keys.Return) { return; }
            e.Handled = true;
            e.SuppressKeyPress = true;

            string barcode = textBoxBarcodeString.Text;
            textBoxBarcodeString.Clear();
            if (ticketManagement.IsValid(barcode, DateTime.Today))
            {
                ticketManagement.Check_in_out(barcode);
                panelInvalidTicket.Hide();
                panelValidTicket.Show();
            }
            else
            {
                panelValidTicket.Hide();
                panelInvalidTicket.Show();
            }
            await Task.Delay(2000);
            panelInvalidTicket.Hide();
            panelValidTicket.Hide();
        }
    }
}
