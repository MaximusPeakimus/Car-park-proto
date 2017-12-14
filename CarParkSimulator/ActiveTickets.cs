using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        private List<Ticket> tickets = new List <Ticket>();

        //Constructors
        public ActiveTickets()
        {

        }

        //Methods
        public List<Ticket> GetTickets()
        {
            return tickets;
        }

        public void AddTicket()
        {
            Ticket ticket = new Ticket();
            tickets.Add(ticket);
        }

        public bool PayTicket(int ticketNo)
        {
            foreach(Ticket ticket in tickets)
            {
                if(ticket.GetHashCode() == ticketNo && !ticket.IsPaid())
                {
                    ticket.SetPaid(true);
                    return true;
                }
            }
            return false;
        }

        public void RemoveTicket()
        {
            tickets.RemoveAt(0);
        }
    }
}
