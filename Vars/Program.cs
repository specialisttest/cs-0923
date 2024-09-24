#define VER

//using MyNamespace;
using Newtonsoft.Json;
using System.Numerics;


namespace Vars
{
    //struct Coords
    //{
    //    public int x;
    //    public int y;

    //    public Coords(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //}

    record struct Coords(int x, int y)
    {
        public int x = x;
        public int y = y;
    }
    struct ColorPoint
    {
        public Coords coords;
        public string color;

        public ColorPoint(int x, int y, string color)
        {
            coords.x = x;
            coords.y = y;
            this.color = color;
        }

        public override string ToString()
        {
            return $"({coords.x}, {coords.y}) {color}";
        }
    }


    enum Colors : byte { Red = 1, Green = 2, Blue = 4 }
    //             0    1      2
    
    class MyNamespace { 
    
    }
    
    
    internal class Program
    {
        readonly int z = 5;

        static void Main(string[] args)
        {
            

            JsonReader reader;

            //MyClass my;
            global::MyNamespace.MyClass my;
            System.String s1;

#if VER
// ...
#else
#error VER is not defined
#endif

#if DEBUG
            Console.WriteLine("Отладочный режим");
#endif

            #region Hello
            string name = "Sergey";
            int age = 46;
            // Hello, Sergey - 46!
            string path = @"c:\cs-0923\Vars";
            string js = @"
                function hello() {
                    alert('Hello');
                }

            ";

            Console.WriteLine($"Hello, {name} - {age}!");
            Console.WriteLine(path);
            Console.WriteLine(js);
            #endregion

            int i = 40;

            Console.WriteLine(i);

            // float point
            double d = 2.5;
            double d2 = 2d;
            double d3 = 2e8;

            float f = 2.5f;

            // fixed point
            decimal dec = 2.5M;

            bool b1 = true;
            bool b2 = false;

            Program p = null;

            int? x = null;

            char ch = '\u002F';
            ch = 'A';

            string s = "abc";

            //System.Int32
            //Int32
            // int
            //UInt32
            //uint
            //Int64
            //long
            //Int128
            //System.Double
            //double

            const int k = 123, k2 = 98;
            //k = 23 + i;
            Console.WriteLine(k);

            var k3 = 123; // int k3 = 123
            var s2 = "abc";// string s2 = "abc "
            //s2 = 567;

            byte bb = 123;
            int ibb = bb;
            byte bb2 = (byte)ibb;

            int v = default;

            int q = 10; // 4 byte
            Console.WriteLine(sizeof(int) );
            int? qn = q + 5;
            if (qn != null)
            //if (qn.HasValue)
                Console.WriteLine(qn.Value.ToString());
            else
                Console.WriteLine("No Value");

            //int n = (qn.HasValue) ? qn.Value : 0;
            //string n = (qn.HasValue) ? qn.Value.ToString() : "No Value";
            int n = qn ?? 0;
            Console.WriteLine(n);

            string userName = null; //"Sergey";
            Console.WriteLine( (userName ?? "no value").ToUpper() );

            //if (qn == null) qn = 17;
            qn ??= 17;
            Console.WriteLine(qn);

            //BigInteger bi1 = 2024;
            //BigInteger bi2 = BigInteger.Pow(bi1, 2024);
            //Console.WriteLine(bi2);


            unsafe
            {
                int l = 123;
                int* pi = &l;
            }

            Colors color = Colors.Green;

            //Coords coords=new Coords(10,20);
            //coords.x = 10;
            //coords.y = 20;

            Coords coords = new(10, 20);
            Coords coords2 = coords;
            coords2.x++;

            Console.WriteLine($"{coords.x}, {coords.y}");
            Console.WriteLine($"{coords2.x}, {coords2.y}");
            Console.WriteLine(coords2);

            ColorPoint cp = new(23, 45, "green");
            Console.WriteLine(cp);





        }
    }
}
