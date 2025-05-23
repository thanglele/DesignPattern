using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class Car
    {
        //public Car()
        //{
        //    seat = "Car: 4 seats";
        //    engine = "Car: V8";
        //    TripComputer = "Car: Trip Computer";
        //    GPS = "Car: GPS";
        //}
        //public Car(string seat, string engine, string TripComputer, string GPS)
        //{
        //    this.seat = seat;
        //    this.engine = engine;
        //    this.TripComputer = TripComputer;
        //    this.GPS = GPS;
        //}
        public string seat;
        public string engine;
        public string TripComputer;
        public string GPS;
        public override string ToString()
        {
            return $"Car: {seat}, {engine}, {TripComputer}, {GPS}";
        }
    }
}
