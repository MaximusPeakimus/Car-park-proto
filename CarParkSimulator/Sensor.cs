using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    abstract class Sensor
    {
        protected bool carOnSensor = false;
        protected CarPark carPark;

        public Sensor (CarPark carPark)
        {
            this.carPark = carPark;
        }

        public abstract void CarDetected();


        public abstract void CarLeftSensor();

        public bool isCarOnSensor()
        {
            return carOnSensor;
        }
    }
}
