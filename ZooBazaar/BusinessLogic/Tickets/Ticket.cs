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

        public string Barcode { get; set; }

        public Ticket(int ticketId, string ticketType, decimal price, string barcode)
        {
            TicketId = ticketId;
            TicketType = ticketType;
            Price = price;
            Barcode = barcode;
        }

        public Ticket(string ticketType, decimal price)
        {
            TicketType = ticketType;
            Price = price;
        }

        public Ticket()
        {

        }
    }
}
