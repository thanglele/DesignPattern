using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class zalo : Base_Decorator
    {
        public zalo(Notifier notifier) : base(notifier)
        {
        }

        public override void send(string message)
        {
            base.send(message);
            Console.WriteLine("Thong bao zalo: " + message);
        }
    }
}
