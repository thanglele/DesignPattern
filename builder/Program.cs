using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Director director = new Director();
            CarBuilder carBuilder = new CarBuilder();

            director.make("SUV");
            director.changeBuilder(carBuilder);
            Car car = carBuilder.getResult();
            Console.WriteLine(car.ToString());
            director.make("SportsCar");
            director.changeBuilder(carBuilder);
            Car car2 = carBuilder.getResult();
            Console.WriteLine(car2.ToString());

            CarManualBuider carManualBuider = new CarManualBuider();
            director.make("SUV");
            director.changeBuilder(carManualBuider);
            Manual car3 = carManualBuider.getResult();
            Console.WriteLine(car3.ToString());
            director.make("SportsCar");
            director.changeBuilder(carManualBuider);
            Manual car4 = carManualBuider.getResult();
            Console.WriteLine(car4.ToString());
        }
    }
}
