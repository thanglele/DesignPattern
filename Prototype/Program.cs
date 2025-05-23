using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MauSac red = new MauSac("1","do");
            HinhVuong hv = new HinhVuong(1, "vuong", red);
            hv.color.name = "xanh";
            Console.WriteLine(red.name);
            HinhVuong h1 = hv.clone() as HinhVuong;
            h1.color.name = "vang";
            Console.WriteLine(hv.color.name);
            Console.WriteLine(red.name);
            //HinhVuong hv1;
            //hv1 = new HinhVuong();
            //hv1.id = hv.id;
            //hv1.name = hv.name;
            //hv1.color = hv.color;
            //HinhVuong hv2 = new HinhVuong(hv);
            //Prototype hv3 = hv.clone();
            //HinhTron ht = new HinhTron(2, "tron", 1);
            //Prototype ht1 = ht.clone();
            //HinhChuNhat hcn = new HinhChuNhat(3, "chunhat", 2);
            //Prototype hcn1 = hcn.clone();

        }
    }
}
