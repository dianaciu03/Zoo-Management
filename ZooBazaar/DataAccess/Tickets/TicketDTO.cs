using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tickets
{
    public class TicketDTO
    {
        public string TicketType { get; init; }
        public decimal TicketPrice { get; init; }
        public DateTime ValidDate { get; init; }
        public decimal Barcode { get; init; }

        public TicketDTO(string ticketType, decimal ticketPrice, DateTime validDate) 
        {
            this.TicketType = ticketType;
            this.TicketPrice = ticketPrice;
            this.ValidDate = validDate;
        }

        public TicketDTO(string ticketType, decimal ticketPrice, DateTime validDate, decimal barcode)
        {
            this.TicketType = ticketType;
            this.TicketPrice = ticketPrice;
            this.ValidDate = validDate;
            this.Barcode = barcode;
        }
    }
}
