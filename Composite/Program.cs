namespace Composite
{
    public interface Phuongtien
    {
        public void PrintPhuongtien();
        public float Vantocphuongtien();
        public int Giaphuongtien();
    }
    public class Car : Phuongtien
    {
        private string ten;
        private float vantoc;
        private int gia;
        public Car(string ten, float vantoc, int gia)
        {
            this.ten = ten;
            this.vantoc = vantoc;
            this.gia = gia;
        }
        public void PrintPhuongtien()
        {
            Console.WriteLine("Day la " + ten);
        }
        public float Vantocphuongtien()
        {
            return vantoc;
        }
        public int Giaphuongtien()
        {
            return gia;
        }
    }
    public class Xemay : Phuongtien
    {
        private string ten;
        private float vantoc;
        private int gia;
        public Xemay(string ten, float vantoc, int gia)
        {
            this.ten = ten;
            this.vantoc = vantoc;
            this.gia = gia;
        }
        public void PrintPhuongtien()
        {
            Console.WriteLine("Day la " + ten);
        }
        public float Vantocphuongtien()
        {
            return vantoc;
        }
        public int Giaphuongtien()
        {
            return gia;
        }
    }
    public class Xedap : Phuongtien
    {
        private string ten;
        private float vantoc;
        private int gia;
        public Xedap(string ten, float vantoc, int gia)
        {
            this.ten = ten;
            this.vantoc = vantoc;
            this.gia = gia;
        }
        public void PrintPhuongtien()
        {
            Console.WriteLine("Day la " + ten);
        }
        public float Vantocphuongtien()
        {
            return vantoc;
        }
        public int Giaphuongtien()
        {
            return gia;
        }
    }

    public class Composite : Phuongtien
    {
        private string tennhom;
        private List<Phuongtien> nhom = new List<Phuongtien>();
        public Composite(string tennhom)
        {
            this.tennhom = tennhom;
        }

        public void themphuongtien(Phuongtien phuongtien)
        {
            nhom.Add(phuongtien);
        }
        public void xoaphuongtien(Phuongtien phuongtien)
        {
            nhom.Remove(phuongtien);
        }
        public int Giaphuongtien()
        {
            int gia = 0;
            for(int i = 0; i < nhom.Count; i++)
            {
                gia += nhom[i].Giaphuongtien();
            }    
            return gia;
        }

        public void PrintPhuongtien()
        {
            Console.WriteLine("Nhom " + tennhom);
            for (int i = 0; i < nhom.Count; i++)
            {
                nhom[i].PrintPhuongtien();
            }
        }

        float Phuongtien.Vantocphuongtien()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Phuongtien car1 = new Car("Car1", 300, 1000000);
            Phuongtien car2 = new Car("Car2", 310, 2000000);
            Phuongtien car3 = new Car("Car3", 350, 3000000);

            Phuongtien xemay1 = new Xemay("Xemay1", 100, 1000);
            Phuongtien xemay2 = new Xemay("Xemay2", 110, 2000);
            Phuongtien xemay3 = new Xemay("Xemay3", 120, 3000);

            Composite composite = new Composite("Oto");
            composite.themphuongtien(car1);
            composite.themphuongtien(car2);
            composite.themphuongtien(car3);
            composite.PrintPhuongtien();
            Console.WriteLine(composite.Giaphuongtien());
        }
    }
}
