using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class CarPark
    {
        //Attributes
        private int currentSpaces;
        private int maxSpace = 5;
        private EntrySensor entry;
        private TicketMachine ticketMachine;
        private TicketValidator ticketValidator;
        private FullSign fullSign;
        private Barrier entryBarrier;
        private Barrier exitBarrier;

        //Constructor
        public CarPark(TicketMachine ticketMachine, TicketValidator ticketValidator, FullSign fullSign, Barrier entryBarrier, Barrier exitBarrier)
        {
            this.ticketMachine = ticketMachine;
            this.ticketValidator = ticketValidator;
            this.fullSign = fullSign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;
            currentSpaces = maxSpace;
            this.entry = new EntrySensor(this);
        }

        //Methods
        public void CarArrivedAtEntrance()
        {
            ticketMachine.CarArrived();
        }

        public void TicketDispensed()
        {
            entryBarrier.Raise();
        }

        public void CarEnteredCarPark()
        {
            currentSpaces--;
            if (currentSpaces == 0)
                fullSign.SetLit(true);
            else
                fullSign.SetLit(false);
            entryBarrier.Lower();
            ticketMachine.ClearMessage();
        }

        public void CarArrivedAtExit()
        {
            ticketValidator.CarArrived();
        }

        public void TicketValidated()
        {
            exitBarrier.Raise();
        }

        public void CarExitedCarPark()
        {
            fullSign.SetLit(false);
            exitBarrier.Lower();
            ticketValidator.ClearMessage();
            currentSpaces++;
        }

        public bool IsFull()
        {
            if (currentSpaces == 0)
                return true;
            else
                return false;
        }

        public bool IsEmpty()
        {
            if (currentSpaces == maxSpace)
                return true;
            else
                return false;
        }

        public bool HasSpace()
        {
            if(currentSpaces > 0)
                return true;
            else
                return false;
        }

        public int GetCurrentSpaces()
        {
            return currentSpaces;
        }

        public int GetMaxSpaces()
        {
            return maxSpace;
        }
    }
}
