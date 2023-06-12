using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tickets
{
    public class TicketDTO
    {
        public int TicketID { get; init; }
        public string TicketType { get; init; }
        public decimal TicketPrice { get; init; }
        public DateTime ValidDate { get; init; }
        public string Barcode { get; init; }

        public TicketDTO(string ticketType, decimal ticketPrice, DateTime validDate, string barcode) 
        {
            this.TicketType = ticketType;
            this.TicketPrice = ticketPrice;
            this.ValidDate = validDate;
            this.Barcode = barcode;
        }

        public TicketDTO(int ticketID, string ticketType, decimal ticketPrice, DateTime validDate, string barcode)
        {
            this.TicketID = ticketID;
            this.TicketType = ticketType;
            this.TicketPrice = ticketPrice;
            this.ValidDate = validDate;
            this.Barcode = barcode;
        }
    }
}
