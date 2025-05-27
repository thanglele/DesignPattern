using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface INotifier
    {
        void send(string message);
    }
    public class Notifier:INotifier
    {
        public void send(string message)
        {
            Console.WriteLine("Thong bao: " + message);
        }
    }
}
