using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class HinhChuNhat : Prototype
    {
        public HinhChuNhat() { }
        public HinhChuNhat(int id, string name, int color)
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
            return new HinhChuNhat(this.id, this.name, this.color);
        }
    }
}
