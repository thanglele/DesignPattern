using System.Xml.Serialization;

namespace Adapter
{
    class Car
    {
        public void laixe()
        {

        }
    }

    class Boat
    {
        public void cheothuyen()
        {

        }
    }

    public interface phuongtien
    {
        public void dichuyen();
    }

    public class car_adapter : phuongtien
    {
        public Car Oto;

        public Car(Car Oto)
        {
            this.Oto = Oto;
        }
        public void dichuyen()
        {
            Oto.laixe();
        }
    }
    public class boat_adapter : phuongtien
    {
        public Boat Thuyen;

        public Boat(Boat Thuyen)
        {
            this.Thuyen = Thuyen;
        }
        public void dichuyen()
        {
            Thuyen.cheothuyen();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Boat boat = new Boat();

            phuongtien pt = new car_adapter(car);
            pt.dichuyen();

            pt = new boat_adapter(boat);
            pt.dichuyen();
        }
    }
}
