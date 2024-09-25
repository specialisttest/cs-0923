namespace Operators
{
    internal class Program
    {
        static string num(int a)
        {
            switch (a)
            {
                case -1:
                case 1 : return "один";
                case 2 : return "два";
                case 3 : return "три";
                default: return "много";
            }
        }

        static string num2(int a) => // switch expression
            a switch
            {
                -1 or 1 => "один",
                2 => "два",
                3 => "три",
                _ => "много"
            };
        


        static void Main(string[] args)
        {
            int n = -5;
            if (n > 0)
            {
                Console.WriteLine("n больше нуля");
                Console.WriteLine("n > 0");
            }
            else 
                if (n > -100)
                    Console.WriteLine("n НЕ больше нуля, но больше -100");
                else
                    Console.WriteLine("n <= 0");

            int a = 0;
            /*string s;
            if (a == 0)
                s = "ноль";
            else
                s = "не ноль";*/

            string s = (a == 0) ? "ноль" : "не ноль";

            Console.WriteLine(s);

            string name = null; // "Sergey";

            //if (name == null) name = "DEFAULT NAME";
            name ??= "DEFAULT NAME";

            Console.WriteLine(  ( name != null ? name : "<пустое имя>" ).ToUpper());

            Console.WriteLine((name ?? "<пустое имя>").ToUpper());
            Console.WriteLine( name?.ToUpper() );

            a = -1;
            switch (a)
            {
                case -1:
                case 1: 
                    Console.WriteLine("один");
                    break; // return
                case 1+1: 
                    Console.WriteLine("два");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                default:
                    Console.WriteLine("много");
                    break;
            }

            Console.WriteLine(num(2));
            Console.WriteLine(num2(3));

            string r = a switch // switch expression
            {
                -1 or 1 => "один",
                2 => "два",
                3 => "три",
                _ => "много"
            };

            Console.WriteLine( r );

            //System.Object o;
            object o = "String";
            o = 5; // boxing
            int k = (int)o; // unboxing


            switch (o) // pattern matching
            {
                case int i when i >=0 && i <=100:
                    Console.WriteLine($"int o in [0, 100] {i}"); break;
                case int: Console.WriteLine("int o"); break;
                case string: Console.WriteLine("string o"); break;
                case double: Console.WriteLine("double o"); break;
                default: Console.WriteLine("???? o"); break;
            }



        }
    }
}
