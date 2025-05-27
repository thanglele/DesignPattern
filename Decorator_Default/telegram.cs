using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class telegram : Base_Decorator
    {
        public telegram(INotifier notifier) : base(notifier)
        {
        }

        public override void send(string message)
        {
            base.send(message);
            Console.WriteLine("Thong bao telegram: " + message);
        }
    }
}
