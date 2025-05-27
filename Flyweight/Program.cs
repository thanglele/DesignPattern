namespace Flyweight
{
    public class Unit
    {
        public int x, y;
        public Unit() { }
        public void FireAt(Unit target)
        {
            Particle p = new Particle();
            p.coords = new int[] { this.x, this.y };
            p.vector = 0;
            p.speed = 1000;
            p.color = "yellow";
            p.sprite = "ihdoifh";

            game g = new game();
            g.addParticle(p);
        }
    }
    public class Particle
    {
        public string color;
        public string sprite;

        public void move()
        {

        }

        public void draw()
        {

        }
    }

    public class MovingParticle
    {
        public Particle p;
        public int[] coords;
        public int vector;
        public float speed;

        public void move()
        {

        }

        public void draw()
        {

        }
    }

    public class game
    {
        public List<Particle> particles = new List<Particle>();

        public void addParticle(Particle p)
        {
            particles.Add(p);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit ban = new Unit();

            for(int i = 0; i < 1000000; i++)
            {
                ban.FireAt(new Unit());
            }    
        }
    }
}
