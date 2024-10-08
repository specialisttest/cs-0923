﻿using System.Text;
using System.Text.RegularExpressions;

namespace ArraysAndStrings
{
    internal class Program
    {
        public override string ToString()
        {
            return "My App class definition";
        }
        static void Main(string[] args)
        {

            Console.WriteLine(args.Length);
            
            //Console.WriteLine("Введите размер массива: ");
            //int k = int.Parse(Console.ReadLine());
            const int k = 5;
            
            int[] ab = null;

            int[] a = new int[] { 100, 200, 300, 500  };

            int[] b = new int[k];

            int[] c = { 100, 200, 300, 400, 500 }; // new int[5]

            Console.WriteLine($"Количество элементов: {b.Length}");
            for(int i=0; i < c.Length; i++)
                Console.WriteLine(c[i]);

            //a.LongLength
            //a.GetLongLength
            //a.Rank

            int[,] matrix =
                {
                    { 1,2,3 },
                    { 4,5,6 }
                };
            int[][] jagged =
                {
                    new int[]{ 1,2,3 },
                    new int[]{ 4,5 }
                };

            Console.WriteLine(matrix.Length);



            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0,4}", matrix[i, j]);
                Console.WriteLine();
            }

            int[] d = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Range r = 2..5;
            int[] d1 = d[r];
            //foreach (int k1 in d1)
            //    Console.WriteLine(k1);

            int[] d2 = d[2..^2];
            foreach (int k1 in d2)
                Console.WriteLine(k1);

            //Span<int> stackMassive = stackalloc int[5] { 100, 200, 3004, 4, 500 };
            //Span<int> stackMassive = stackalloc int[5] { 100, 200, 3004, 4, 500 };
            Span<int> stackMassive = [ 100, 200, 3004, 4, 500 ];
            foreach (int element in stackMassive)
                Console.WriteLine(element);

            string[] names = new string[5];

            //Console.WriteLine((names[0] != null) ? names[0].ToUpper() : null);
            Console.WriteLine(names[0]?.Trim()?.ToUpper());

            string n = string.Empty;
            string s = "Sergey";
            //s.Length
            string ss = "Привет, " + s + "!";
            // "Sergey"
            // "Привет, "
            // "!"
            // "Привет, Sergey"
            // "Привет, Sergey!"

            Program app = new Program();

            Console.WriteLine( s.ToUpper() );
            Console.WriteLine( s = s.ToUpper());
            Console.WriteLine(s);

            Console.WriteLine(app.ToString());

            string numStr = "123";
            //int num = int.Parse(numStr);
            //double.Parse( numStr );

            int num;
            if (int.TryParse(numStr, out num))
            {
                Console.WriteLine(num * 2);
            }
            else
                Console.WriteLine("не число");

            int num2 = Convert.ToInt32(numStr);
            // 1 2 3 4 5 .. 100

            // BAD
            //string result = string.Empty;
            //for(int i=1; i <= 100; i++)
            //    result += i.ToString() + " ";
            // ""
            // " "
            // "1"
            // "1 "
            // "1 2"
            // "1 2 "

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 100; i++)
                sb.Append(i).Append(' ');

            string result = sb.ToString();

            string phone = "999 13-45-78";
            Regex reg = new Regex(@"\d\d\d [1..9]\d\d-\d\d-\d\d");


            if (reg.IsMatch(phone))
                Console.WriteLine(phone);
            else
                Console.WriteLine("wrong phone format");

            Console.WriteLine(result);
        }
    }
}
