namespace AdapterEx1
{
    public class RoundPeg
    {
        private int radius;

        public RoundPeg(int radius)
        {
            this.radius = radius;
        }

        public int getRadius()
        {
            return this.radius;
        }
    }
    public class RoundHole
    {
        private int radius;

        public RoundHole(int radius)
        {
            this.radius = radius;
        }
        public int getRadius()
        {
            return this.radius;
        }

        public bool fits(RoundPeg Peg)
        {
            if(Peg.getRadius() <= this.radius)
            {
                return true;
            }    
            return false;
        }
    }
    public class SquarePeg
    {
        private int width;
        public SquarePeg(int width)
        {
            this.width = width;
        }
        public int getWidth()
        {
            return this.width;
        }
    }
    public class SquarePegAdapter
    {
        private SquarePeg peg;
        public SquarePegAdapter(SquarePeg peg)
        {
            this.peg = peg;
        }
        public int getRadius()
        {
            return Convert.ToInt32(peg.getWidth() * (Math.Sqrt(2) / 2));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai báo hố
            RoundHole hole = new RoundHole(2);

            //Khai báo một hộp vuông
            SquarePeg square = new SquarePeg(4);

            //Convert giả định hộp vuông trên bán kính tròn
            RoundPeg roundPeg = new RoundPeg(new SquarePegAdapter(square).getRadius());

            //Trả về trạng thái có vừa hay không?
            if (hole.fits(roundPeg))
            {
                Console.WriteLine("Fit");
            } else 
            {
                Console.WriteLine("No Fit"); 
            }
        }
    }
}
