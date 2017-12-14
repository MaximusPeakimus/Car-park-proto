using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
    {
        private string message;
        private ActiveTickets activeTickets;
        private CarPark carPark;

        public TicketValidator (ActiveTickets activeTickets)
        {
            this.activeTickets = activeTickets;
        }
        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please insert your ticket.";
        }

        public bool TicketEntered()
        {
            if (activeTickets.GetTickets()[0].IsPaid())
            {
                message = "Thank you, drive safely.";
                activeTickets.RemoveTicket();
                return true;
            }
            else
            {
                message = "Error: Ticket not paid for!";
                return false;
            }

        }
        public bool PayTicket(int ticketNo)
        {
            return activeTickets.PayTicket(ticketNo);
        }

        public void ClearMessage()
        {
            message = "";
        }

        public string GetMessage()
        {
            return message;
        }
    }
}
