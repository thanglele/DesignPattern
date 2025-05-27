using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class facebook : Base_Decorator
    {
        public facebook(INotifier notifier) : base(notifier)
        {
        }

        public override void send(string message)
        {
            base.send(message);
            Console.WriteLine("Thong bao facebook: " + message);
        }
    }
}
