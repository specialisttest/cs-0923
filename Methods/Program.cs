using System.Runtime.InteropServices;
using ArrayResult = (int min, int max, long sum, double avg);

namespace Methods
{

    struct VeryLarge
    {
        public long Val1;
        public long Val2;
        public void Copy()
        {
            Console.WriteLine("Copy invoke");
            this.Val1 = this.Val2;
        }
    }
    internal class Program
    {

        static double SinTri(double a, double b)
        { 
            double H() 
            {
                return Math.Sqrt(a * a + b * b);
            }
            
            
            return b / H();
        }
        
        // overloading
        public static void SayHello()
        {
            Console.WriteLine("Привет!");
        }


        public static void SayHello(string name = "Незнакомец", int age = 18)
        {
            Console.WriteLine($"Привет, {name} - {age}!");
            
        }
        //static double Average(int a, int b)
        //{ 
        //    double avg = (a + b) / 2d;
        //    return avg;
        //}

        //static double Average(int a, int b)
        //{
        //    return (a + b) / 2d;
        //}

        static double Average(int a, int b) => (a + b) / 2d;


        static double Average(int a, int b, int c)
        {
            double avg = (a + b + c) / 3d;
            return avg;
        }

        static double Average(params int[] m)
        { 
            long sum = 0L;
            foreach(int k in m)
                sum += k;
            return (double)sum / m.Length;
        }


        //static ArrayResult MinMax(int[] m)
        static (int min,int max, long sum, double avg) MinMax(int[] m)
        {
            int min = m[0];
            int max = m[0];
            long sum = 0L;
            foreach (int k in m)
            {
                if (k > max) max = k;
                if (k < min) min = k;
                sum += k;
            }

            return (min,max,sum, (double)sum / m.Length);
        }

        static ref int Min(int[] m) 
        {
            ref int min = ref m[0];
            for (int i = 0; i < m.Length; i++)
                if (m[i] < min) min = ref m[i];

            return ref min;
        }

        static void Test1(int a)
        {
            a++;
            Console.WriteLine($"Test 1 a = {a}"); // 11
        }
        static void Test2(ref int a)
        {
            a++;
            Console.WriteLine($"Test 2 a = {a}"); // 11
        }
        static void Test3(out int a)
        {
            a = 10;
            Console.WriteLine($"Test 3 a = {a}"); // 11
        }

        static void Test4(in /*ref readonly*/ int a)
        {
            //a = 10;
            //a++;
            Console.WriteLine($"Test 4 a = {a}"); // 11
        }

        static void Test5( in /*ref readonly */ VeryLarge vl)
        {
            //vl.Val1 = 10;
            //vl.Val2 = 20;
            vl.Copy();
            Console.WriteLine($"Test 5 {vl.Val1} {vl.Val2}"); 
        }

        static void Main(string[] args)
        {
            {
                VeryLarge vl;
                vl.Val1 = 100;
                vl.Val2 = 200;
                Test5(vl);
                Console.WriteLine($"Main 5 {vl.Val1} {vl.Val2}");
            }
            {
                int a = 10;
                Test1(a);
                Console.WriteLine($"Main 1 a = {a}"); // 10
            }
            {
                int a = 10;
                Test2(ref a);
                Console.WriteLine($"Main 2 a = {a}"); // 11
            }
            {
                int a;
                Test3(out a);
                Console.WriteLine($"Main 3 a = {a}"); // 11
            }
            {
                int a = 10;
                Test4(a);
                Console.WriteLine($"Main 4 a = {a}"); // 10
            }

            // non-static
            //Program p = new Program();
            //p.SayHello();

            //Program.SayHello();
            SayHello("Сергей", 45);
            
            SayHello(age:40, name:"Андрей");

            SayHello("Анна");
            SayHello(age: 27);

            SayHello();

            double x = Average(11, 12);
            Console.WriteLine(x);

            Console.WriteLine( Average(1, 2) );
            Console.WriteLine( Average(1, 2, 3) );
            Console.WriteLine( Average(new int[] { 10, 11, 12, 13 }) );
            Console.WriteLine( Average( [ 10, 11, 12, 13 ] ) );
            Console.WriteLine( Average( 10, 11, 12, 13 ) );
            Console.WriteLine( Average( 10, 11, 12, 13, 14, 15 ) );

            //ArrayResult r = MinMax([101, 56, 17, 23]);
            int[] m = { 101, 56, 17, 23 };
            var r = MinMax(m);

            Console.WriteLine( r );
            Console.WriteLine( $"Min : {r.min} Max : {r.max} Summa : {r.sum} Average : {r.avg}");

            foreach(int k in m) Console.Write($"{k} ");
            Console.WriteLine();

            ref int min = ref Min(m);
            min = 0;

            foreach (int k in m) Console.Write($"{k} ");
            Console.WriteLine();

        }
    }
}
