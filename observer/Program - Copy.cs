//namespace observer
//{
//    public interface observer
//    {
//        public void sendMessages(int temp, string thoitiet);
//    }

//    public class Mobile : observer
//    {
//        public void sendMessages(int temp, string thoitiet)
//        {
//            Console.WriteLine("MOBILE: " + temp + "///" + thoitiet);
//        }
//    }

//    public class Website : observer
//    {
//        public void sendMessages(int temp, string thoitiet)
//        {
//            Console.WriteLine("Website: " + temp + "///" + thoitiet);
//        }
//    }

//    public class Desktop : observer
//    {
//        public void sendMessages(int temp, string thoitiet)
//        {
//            Console.WriteLine("Desktop: " + temp + "///" + thoitiet);
//        }
//    }

//    public class Tivi : observer
//    {
//        public void sendMessages(int temp, string thoitiet)
//        {
//            Console.WriteLine("TV: " + temp + "///" + thoitiet);
//        }
//    }

//    public class tramthoitiet
//    {
//        public int temp;
//        public string thoitiet;
//        List<observer> list = new List<observer>();
//        public void subscribe(observer subscriber)
//        {
//            list.Add(subscriber);
//        }
//        public void unsubscribe(observer subscriber)
//        {
//            list.Remove(subscriber);
//        }
//        public void notifier()
//        {
//            foreach (observer observer in list)
//            {
//                observer.sendMessages(temp, thoitiet);
//            }    
//        }

//        public void updateData(int temp, string thoitiet)
//        {
//            this.temp = temp;
//            this.thoitiet = thoitiet;

//            notifier();
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            tramthoitiet tram = new tramthoitiet();

//            Mobile iphone = new Mobile();
//            Website google = new Website();
//            Desktop windows = new Desktop();

//            tram.subscribe(iphone);
//            tram.subscribe(google);

//            tram.updateData(15, "Lanh");

//            tram.updateData(40, "Nong vaoo");

//            tram.unsubscribe(google);
//            tram.subscribe(windows);

//            tram.updateData(25, "Math Math");

//            Tivi samsung = new Tivi();
//            tram.subscribe(samsung);
//            tram.updateData(30, "ok ok");

//        }
//    }
//}
