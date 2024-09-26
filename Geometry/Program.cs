using System.Numerics;

namespace Geometry
{
    enum Figures { Romb, Rect, Circle }
    struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;

        public double Square() => (type) switch
        {
            Figures.Romb => a * b / 2d,
            Figures.Rect => a * b,
            Figures.Circle => Math.PI * a * a
        };
    }
    internal class Program
    {
        static BigInteger Factorial(int n)
        {
            BigInteger r = 1;
            for (int i = 1; i <= n; i++)
                r = r * i;
            return r;   
        }
        
        static void Main(string[] args)
        {
            Fdata fd = new Fdata() { a = 4, b = 3, type = Figures.Romb };
            Console.WriteLine(fd.Square());
            Console.WriteLine(
                new Fdata() { a = 10, type = Figures.Circle}.Square());
            Console.WriteLine(
               new Fdata() { a = 10, b=20, type = Figures.Rect }.Square());

            Console.WriteLine(Factorial(100));
        }
    }
}
