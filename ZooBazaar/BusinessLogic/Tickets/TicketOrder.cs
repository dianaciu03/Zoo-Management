using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Tickets
{
    public class TicketOrder
    {
        private List<Ticket> tickets = new List<Ticket>();
        public int OrderId { get; set; }
        public string DiscountCode { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }

        public List<Ticket> Tickets { get { return tickets; } set { tickets = value; } }

        public TicketOrder(DateTime date)
        {
            Date = date;
        }

        public TicketOrder()
        {
        }

        public TicketOrder(int id)
        {
            OrderId = id;
        }

        public void AddTicketToOrder(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return tickets;
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
