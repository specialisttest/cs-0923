﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public static class MyContainer
    { 
    
    }


    public partial class Course
    {
        #region Property

        /*private string title = "Новый курс";
        public string Title
        {
            get { return title; }
            set { title = value; }
        }*/
        /*public string Title
        {
            get => title;
            //set => title = value; 
        }*/

        //public string Title => title; //  { get => title; }

        // auto property (auto create field)
        //public string Title { get; set; }
        public /*required*/ string Title { get; init;  } = "Новый курс";


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
        #endregion

        private static int counter = 0;

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

        // Без модификатора доступа (private), не должен возращать значение (void)
        partial void Validate();

        public void Show()
        {

            Validate();
            // this - ссылка на объект, для которого вызван этот метод
            Console.WriteLine($"{this.Title} : {Length}");
        }

        ~Course() 
        { 
            Console.WriteLine("~Course()");
        }

    }
}
