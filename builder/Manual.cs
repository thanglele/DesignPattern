using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class Manual
    {
        public string seat;
        public string engine;
        public string TripComputer;
        public string GPS;
        public override string ToString()
        {
            return $"Manual: {seat}, {engine}, {TripComputer}, {GPS}";
        }
    }
}
