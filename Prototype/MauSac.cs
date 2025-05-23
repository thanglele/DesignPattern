using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class MauSac
    {
        public MauSac() { }
        public MauSac(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string id;
        public string name;
    }
}
