namespace observer
{
    public interface EventListeners
    {
        public void update(string filenames);
    }
    public class EmailAlertsListener
    {
        public void update(string filenames)
        {
            Console.WriteLine("");
        }
    }

    public class LoggingListener
    {
        public void update(string filenames)
        {
            Console.WriteLine("");
        }
    }

    public class EventManager
    {

    }

    public class Editor
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
