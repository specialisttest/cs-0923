using static System.Math;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course.ShowCoursesCounter();
            
            Course c1 = new Course("C# 12", 40) { Description = "Введение в язык c# 12"};
            //c1.Title = "C# 12";
            //c1.Length = 40;
            c1.Length = 48; // call set
            //c1.Title = "Язык C# 12";
            Console.WriteLine(c1.Length); // call get

            //c1.SetLength(48);
            //Console.WriteLine(c1.GetLength());

            c1.Show(); // this == c1

            Course c2 = new Course("Patterns OOP", 24);
            //c2.Title = "Patterns OOP";
            //c2.Length = 24;

            c2.Show(); // c2 == this

            Course c3 = new Course();
            c3.Show();

            // y = log(sin(M_PI * x))
            double x = 5;
            //double y = Math.Log(Math.Sin(Math.PI * x));
            double y = Log(Sin(PI * x));

            //c3 = null;
            //GC.Collect();

            Course.ShowCoursesCounter();
        }
    }
}
