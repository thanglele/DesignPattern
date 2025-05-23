using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class Director
    {
        private builder builder;
        public void make(string type)
        {
            if (type == "SUV")
            {
                builder.reset();
                builder.setEngine();
                builder.setGPS();
                builder.setSeat();
                builder.setTripComputer();
            }
            else if (type == "SportsCar")
            {
                builder.reset();
                builder.setEngine();
                builder.setGPS();
                builder.setTripComputer();
            }
        }
        public void changeBuilder(builder builder)
        {
            this.builder = builder;
        }
    }
}
