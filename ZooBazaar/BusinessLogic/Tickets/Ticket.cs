using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Tickets
{
    public class Ticket
    {
        public int TicketId { get; set; }

        public string TicketType { get; set; }

        public decimal Price { get; set; }

        public decimal Barcode { get; set; }

        public Ticket(string ticketType, decimal price, decimal barcode)
        {
            TicketType = ticketType;
            Price = price;
            Barcode = barcode;
        }

        public Ticket(string ticketType, decimal price)
        {
            TicketType = ticketType;
            Price = price;
        }

        public Ticket() { }
    }
}
