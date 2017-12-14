using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Barrier
    {
        //Attributes
        private bool lifted = false;

        //Constructors
        public Barrier()
        {
            
        }

        //Methods
        public void Lower()
        {
            lifted = false;
        }

        public void Raise()
        {
            lifted = true;
        }

        public bool IsLifted()
        {
            return lifted;
        }
    }
}