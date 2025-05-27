using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Notifier
    {
        public virtual void send(string message)
        {
            Console.WriteLine("Thong bao: " + message);
        }
    }
}
