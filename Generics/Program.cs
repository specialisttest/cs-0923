using System.Collections.Generic;

namespace Generics
{
    class ReadonlyStorage<T>
        where T : IComparable<T>
    { 
        public T Data { get; init; }


        public bool IsGreater(T x)
        {
            return Data.CompareTo(x) > 0;
        }

        public ReadonlyStorage(T data)
        {
            Data = data;
        }
    }


    internal class Program
    {

        static void Swap<T>(ref T a, ref T b)
            where T : struct
        {
            //T c = default(T);
            T c = a;
            a = b;
            b = c;
        }
        
        static bool IsGreater<T>(T a, T b)
                where T : IComparable<T>
        {
            return a.CompareTo(b) > 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsGreater(3, 2));
            Console.WriteLine(IsGreater(3.2, 2.5));
            Console.WriteLine(IsGreater<string>("abc", "cde"));

            ReadonlyStorage<int> r1 = new ReadonlyStorage<int>(5);
            ReadonlyStorage<double> r2 = new ReadonlyStorage<double>(2.5);
            ReadonlyStorage<string> r3 = new ReadonlyStorage<string>("Abc");
            //ReadonlyStorage<Program> r4 = new ReadonlyStorage<Program>(new Program());


            Console.WriteLine(r1.Data);
            Console.WriteLine(r1.IsGreater(3));
            Console.WriteLine(r2.Data);
            Console.WriteLine(r3.Data);
            Console.WriteLine(r3.IsGreater("Cde"));
            //Console.WriteLine(r4.Data);

            int k = 0; //     default(int);
            string s = default(string);

            IList<string> titles = new List<string>() { "C# 12", "Java", "Python" };

        }
    }
}
