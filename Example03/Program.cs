

namespace Example03
{
    public interface Shape
    {
        Shape clone();
    }

    public class Rectangle : Shape
    {
        public Rectangle() 
        { 

        };
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
