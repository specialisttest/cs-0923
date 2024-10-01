using System.Diagnostics;
using System.Numerics;

namespace ExceptionProject
{
    internal class Program
    {

        static void Divide(string s1, string s2)
        {
            try
            {
                int n1 = int.Parse(s1);
                int n2 = int.Parse(s2);

                if (n1 < 0 || n1 > 100)
                    //throw new ArgumentOutOfRangeException("n1 out of [0..100]");
                    throw new MyException("n1 out of [0..100]", n1);

                int n = n1 / n2;

                Console.WriteLine(n);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Не число");
            }
            catch (MyException e) when (e.InvalidData > 0)
            {
                Console.WriteLine($"{e.Message} Invalid data: {e.InvalidData}");
                //throw; // throw e;
                throw new ArgumentException(e.Message, e);
            }

            Console.WriteLine("продолжение Divide()");

        }

        static void Main(string[] args)
        {
            try
            {
                Divide("23", "4");

                // unchecked by default (если не включено в свойствах проекта)
                checked
                {
                    int a = int.MaxValue;
                    Console.WriteLine(a);
                    //a = unchecked(a + 1);
                    //a = checked(a + 1);
                    a++;
                    Console.WriteLine(a);
                }

                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //Console.WriteLine(e);
                //Debug.WriteLine(e.ToString());
                Trace.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("finally");
            }

            Console.WriteLine("продолжение Main()");

            try { }
            finally { }
        }
    }
}
