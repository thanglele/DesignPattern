using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class HinhTron : Prototype
    {
        public HinhTron() { }
        public HinhTron(int id, string name, int color)
        {
            this.id = id;
            this.name = name;
            this.color = color;
        }
        private int id;
        private string name;
        private int color;

        public Prototype clone()
        {
            return new HinhTron(this.id, this.name, this.color);
        }
    }
}
