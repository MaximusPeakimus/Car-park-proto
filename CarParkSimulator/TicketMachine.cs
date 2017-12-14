using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketMachine
    {
        private string message;
        private CarPark carPark;
        private ActiveTickets activeTickets;
        
        public TicketMachine (ActiveTickets activeTickets)
        {
            this.activeTickets = activeTickets;
        }

        public void AssignCarPark( CarPark carPark )
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please press to get a ticket.";
        }

        public void PrintTicket()
        {
            message = "Please park in space: " + Convert.ToString((carPark.GetMaxSpaces() - carPark.GetCurrentSpaces()) + 1);
            activeTickets.AddTicket();
            carPark.TicketDispensed();
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
