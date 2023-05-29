using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Tickets
{
    public class TicketOrder
    {
        private List<Ticket> tickets;
        public int OrderId { get; set; }
        public string DiscountCode { get; set; }
        public decimal TotalPrice { get; set; }

        public TicketOrder()
        {
            tickets = new List<Ticket>();
        }

        public TicketOrder(int id)
        {
            OrderId = id;
            tickets = new List<Ticket>();
        }

        public void AddTicketToOrder(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public void CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach(Ticket ticket in tickets)
            {
                totalPrice += ticket.Price;
            }
            TotalPrice = totalPrice;
        }

    }
}
