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
