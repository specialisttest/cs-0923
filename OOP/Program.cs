using static System.Math;

/* В программе создать объекты классов
 * Romb, Square Circle.наследники Shape
 * Создать массив Shape[] scene и добавить
 * в него ссылки на созданные объекты
 * Сделать метод DrawScene, которые 
 * перебирает этот массив и для каждого 
 * объекта вызывает метод Draw()
 * 
 * 
 */
namespace OOP
{

    public partial class Course
    {
        public string Description { get; init; }

        partial void Validate()
        {
            Console.WriteLine("Validation...");
        }

        public class Nested
        {
            public static void Reset()
            {
                Course.counter = 0;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Course.Nested n = new Course.Nested();


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

            // для LINQ
            var person = new { Name = "Sergey", Age = 47 };

            //Console.WriteLine($"{person.Name} : {person.Age}");
            Console.WriteLine(person.Name) ;

            Circle cr1 = new Circle("red",0,0,100);
            Shape s = cr1; // implicit conv
            
            /* VTM
             * 
             * Class    Method      Address
             * Shape    Draw        XXXX
             * Circle   Draw        YYYY
             * Romb     Draw        ZZZZ
             * 
             * 
             * */
            
            
            s.Draw(); // Circle.Draw() - polymorphism

            //s = new Shape();

            /*if (s is Circle) 
            {
                Circle cr2 = (Circle)s; // explicit conv
                cr2.Scale(1.5);
            }*/
            /*if (s is Circle cr2)
            {
                cr2.Scale(1.5);
            }*/

            /*Circle cr2 = s as Circle;
            if (cr2 != null)
                cr2.Scale(1.5);*/

            (s as Circle)?.Scale(1.5);
            //if (s is Circle cr2) cr2.Scale(1.5);

            cr1.Draw(); // Circle.Draw
        }
    }
}
