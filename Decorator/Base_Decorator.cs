using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Base_Decorator : Notifier
    {
        public Notifier Wrappee;
        public Base_Decorator(Notifier notifier) 
        {
            Wrappee = notifier;
        }

        public override void send(string message)
        {
            Wrappee.send(message);
        }
    }
}
