namespace Iterations
{
    internal class Program
    {
        public static IEnumerable<string> GetCourses()
        {
            //return new List<string> { "Язык C# 12.0",
            //    "Клиент-серверная разработка под .Net На C#", "Pattern OOP"};
            yield return "Язык C# 12.0";
            yield return "Pattern OOP";
            //yield break; // заканчивает создание генератора
            yield return "Клиент-серверная разработка под .Net На C#";
        }
        
        static void Main(string[] args)
        {
            //int i = 10;
            ////i = i + 1; 
            ////i += 1;
            //int x = i++;

            //Console.WriteLine(i);
            //Console.WriteLine(x);

            for (int i = 1; i <= 10; i++)
            {
                if (i == 8) break;
                if (i == 4) continue;
                Console.WriteLine(i);
            }

            // 1 2 3 .. 10
            // 2 4 6 .. 20
            // ...
            // 10 20 30 .. 100
            for (int i = 1;i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 5) goto metka;
                    Console.Write("{0, -5}", i * j);
                }
                Console.WriteLine();
            }
        metka:
            Console.WriteLine("\ncontinue");

            int a = 2000;
            while (a < 1000)
            { 
                Console.WriteLine(a);
                a *= 2;
            }

            a = 2;
            do 
            {
                Console.WriteLine(a);
                //a *= 2;
            } while ( (a *= 2) < 1000);

            /*
             * Вывести числа Фибоначчи < 1000
             * 0 1 1 2 3 5 8 13 21 ...
             * 
             */
            int k1 = 0, k2 = 1, k3;
            Console.Write($"{k1} {k2} ");
            while ((k3 = k1 + k2) < 1000)
            {
                Console.Write("{0} ", k3);
                k1 = k2;
                k2 = k3;
            }

            Console.WriteLine();

            ICollection<string> courses = new List<string> { "Язык C# 12.0",
                "Клиент-серверная разработка под .Net На C#", "Pattern OOP"};

            //for (int i = 0; i < courses.Count; i++)
            //    Console.WriteLine(courses[i]); // не работает для ICollection

            // если источник реализует IEnumerable или содержит метод IEnumerator GetEnumerator()
            //foreach (var course in courses)
            //    Console.WriteLine(course);

            //IEnumerator<string> en = courses.GetEnumerator();
            //while (en.MoveNext()) 
            //{
            //    string course = en.Current;
            //    Console.WriteLine( course );
            //}

            foreach (var course in GetCourses())
                Console.WriteLine(course);


            //int n = int.Parse( Console.ReadLine() );

            /*
             * 1. Пользователь вводит целое число от 0 до 9 - количество ворон на ветке
             *    На ветке 5 ворон
             * 2. Для любого числа
             * 
             **/


        }
    }
}
