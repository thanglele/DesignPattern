using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface Transport
    {
        void deliver();
    }

    public class Truck : Transport
    {
        public void deliver()
        {
            Console.WriteLine("Van chuyen bang xe tai");
        }
    }
    public class Ship : Transport
    {
        public void deliver()
        {
            Console.WriteLine("Van chuyen bang tau thuy");
        }
    }

    public class Train : Transport
    {
        public void deliver()
        {
            Console.WriteLine("Van chuyen bang tau hoa");
        }
    }
    public abstract class Logistic
    {
        public void planDelivery() 
        {
            Transport t = createTransport();
            t.deliver();
        }
        
        //Factory Method
        public abstract Transport createTransport();
    }

    public class RoadLogistic : Logistic
    {
        public override Transport createTransport()
        {
            return new Truck();
        }
    }

    public class SeaLogistic : Logistic
    {
        public override Transport createTransport()
        {
            return new Ship();
        }
    }

    public class SatLogistic : Logistic
    {
        public override Transport createTransport()
        {
            return new Train();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logistic log = new RoadLogistic();
            log.planDelivery();
            log = new SeaLogistic();
            log.planDelivery();
            log = new SatLogistic();
            log.planDelivery();
        }
    }
}
