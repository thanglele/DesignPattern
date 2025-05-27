using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Base_Decorator : INotifier
    {
        private INotifier Wrappee;
        public Base_Decorator(INotifier notifier) 
        {
            Wrappee = notifier;
        }

        public virtual void send(string message)
        {
            Wrappee.send(message);
        }
    }
}
