using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class HinhVuong : Prototype
    {
        public HinhVuong(int id)
        {
            this.id = id;
        }
        public HinhVuong(int id, string name, MauSac color)
        {
            this.id = id;
            this.name = name;
            this.color = new MauSac(color.id, color.name);
        }

        public HinhVuong(HinhVuong hv)
        {
            this.id=hv.id;
            this.name=hv.name;
            this.color = new MauSac(hv.color.id, hv.color.name); //Deep Copy: copy bên heap, ShallowCopy: copy bên stack
        }
        public int id;
        public string name;
        public MauSac color;

        public Prototype clone()
        {
            return new HinhVuong(this.id, this.name, this.color);
        }
    }
}
