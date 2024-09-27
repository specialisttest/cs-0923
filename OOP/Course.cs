using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Course
    {
        /*private string title = "Новый курс";
        public string Title
        {
            get { return title; }
            set { title = value; }
        }*/

        // auto property
        //public string Title { get; set; }
        public string Title { get; init; } = "Новый курс";

        public string Description { get; init; }

        private int length;
        public int Length
        {
            get { return length; }
            /*private*/
            set
            {
                if (value >= 8 && value <= 48)
                    this.length = value;
                else
                    throw new ArgumentException("Course Length out of [8..48]");
            }
        }

        static int counter = 0;

        // вызывается автоматически CLR при первом обращении к классу
        // используется для сложной инициализации статических полей
        static Course()
        {
        
        }

        public static void ShowCoursesCounter()
        {
            Console.WriteLine($"Total Courses: {counter}");
        }


        public Course()
            : this("New course", 16) // вызов другого конструктора этого же класса
        {

        }

        public Course(string Title, int Length = 8) 
        { 
            this.Title = Title;
            this.Length = Length; // call set
            counter++;
        }

        public void Show()
        {
            // this - ссылка на объект, для которого вызван этот метод
            Console.WriteLine($"{this.Title} : {Length}");
        }

        ~Course() 
        { 
            Console.WriteLine("~Course()");
        }

    }
}
