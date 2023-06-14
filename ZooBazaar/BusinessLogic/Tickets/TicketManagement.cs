using DataAccess.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Tickets
{
    public class TicketManagement
    {
        TicketRepository ticketRepository;

        public TicketManagement()
        {
            ticketRepository = new TicketRepository();
        }

        private TicketDTO TicketToDTO(Ticket ticket, DateTime date)
        {
            return new TicketDTO(
                ticket.TicketType,
                ticket.Price,
                date);
        }

        private Ticket DTOToTicket(TicketDTO ticket)
        {
            return new Ticket(
                ticket.TicketType,
                ticket.TicketPrice,
                ticket.Barcode);
        }

        public TicketOrder AddOrder(TicketOrder order)
        {
            List<Ticket> ticketsReturn = new List<Ticket>();
            TicketOrder ticketOrder = new TicketOrder();
            foreach (Ticket ticket in order.Tickets)
            {
                ticketsReturn.Add(DTOToTicket(ticketRepository.AddTicket(TicketToDTO(ticket, order.Date))));
            }
            ticketOrder.TotalPrice = order.TotalPrice;
            ticketOrder.DiscountCode = order.DiscountCode;
            ticketOrder.Date = order.Date;
            ticketOrder.Tickets = ticketsReturn;

            return ticketOrder;
        }

        public bool IsValid(string barcode, DateTime date)
        {
            if (ticketRepository.IsValid(barcode, date) && !ticketRepository.NotUsed(barcode))
            {
                return true;
            }
            return false;
        }

        public void Check_in_out(string barcode)
        {
            if (ticketRepository.AlreadyCheckedIn(barcode))
            {
                ticketRepository.CheckOut(barcode, DateTime.Now);
            }
            else
            {
                ticketRepository.CheckIn(barcode, DateTime.Now);
            }
        }

    }
}
