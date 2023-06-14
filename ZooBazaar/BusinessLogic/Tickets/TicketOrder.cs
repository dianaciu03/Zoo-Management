using DataAccess.Tickets;
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
        public string DiscountCodeApplied { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMethod { get; set; }

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

        public decimal CalculateTotalPriceWithDiscount(string discount)
        {
            decimal totalPrice = 0;
            foreach (Ticket ticket in tickets)
            {
                totalPrice += ticket.Price;
            }
            TicketRepository tr = new TicketRepository();
            if (tr.IsValidDiscountCode(discount))
            {
                totalPrice -= 5; 
            }
            return totalPrice;
        }

    }
}
