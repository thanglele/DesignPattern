using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class CarBuilder : builder
    {
        private Car car = new Car();
        public void setSeat()
        {
            car.seat = "Car has 4 seat";
        }
        public void setEngine()
        {
            car.engine = "Car: V8";
        }
        public void setTripComputer()
        {
            car.TripComputer = "Car: Trip Computer";
        }
        public void setGPS()
        {
            car.GPS = "Car: GPS";
        }
        public void reset()
        {
            car = new Car();
        }
        public Car getResult()
        {
            return car;
        }
    }
}
