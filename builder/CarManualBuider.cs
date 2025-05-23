using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class CarManualBuider : builder
    {
        private Manual manual = new Manual();
        public void setSeat()
        {
            manual.seat = "CarManual: Leather";
        }
        public void setEngine()
        {
            manual.engine = "CarManual: V8";
        }
        public void setTripComputer()
        {
            manual.TripComputer = "CarManual: Trip Computer";
        }
        public void setGPS()
        {
            manual.GPS = "CarManual: GPS";
        }
        public void reset()
        {
            manual = new Manual();
        }
        public Manual getResult()
        {
            return manual;
        }
    }
}
