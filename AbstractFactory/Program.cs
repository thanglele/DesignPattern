using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface Chair
    {
        void hasLegs();
        void sitOn();
    }
    public interface CoffeeTable
    {

    }

    public interface Sofa
    {

    }

    public class VictorianSofa : Sofa
    {
     
    }
    public class MordernSofa : Sofa
    {

    }

    public class VictorianCoffeeTable : CoffeeTable
    {

    }
    public class MordernCoffeeTable : CoffeeTable
    {

    }

    public class VictorianChair : Chair
    {
        void Chair.hasLegs()
        {
            
        }

        void Chair.sitOn()
        {
            
        }
    }
    public class MordernChair : Chair
    {
        void Chair.hasLegs()
        {

        }

        void Chair.sitOn()
        {

        }
    }
    public interface FurnitureFactory
    {
        Chair createChair();
        CoffeeTable createCoffeeTable();
        Sofa createSofa();
    }

    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public Chair createChair() { return new VictorianChair(); }
        public CoffeeTable createCoffeeTable() { return new VictorianCoffeeTable(); }
        public Sofa createSofa() { return new VictorianSofa(); }
    }
    public class MordernFurnitureFactory : FurnitureFactory
    {
        public Chair createChair() { return new MordernChair(); }
        public CoffeeTable createCoffeeTable() { return new MordernCoffeeTable(); }
        public Sofa createSofa() { return new MordernSofa(); }
    }

    class sinhvien
    {
        private static sinhvien instance;

        public string ten;
        private sinhvien()
        {

        }

        public static sinhvien getInstance()
        {
            if (instance == null)
            {
                instance = new sinhvien();
            }

            return instance;
        }

        public void getTen()
        {
            Console.WriteLine(ten);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sinhvien x = sinhvien.getInstance();
            x.ten = "A1";
            x.getTen();

            x = sinhvien.getInstance();
            x.ten = "A2";
            x.getTen();

            //FurnitureFactory abstractFactory = new MordernFurnitureFactory();
            //abstractFactory.createChair();
            //abstractFactory.createCoffeeTable();
            //abstractFactory.createSofa();

            //abstractFactory = new VictorianFurnitureFactory();
            //abstractFactory.createChair();
            //abstractFactory.createCoffeeTable();
            //abstractFactory.createSofa();

            
        }
    }
}
