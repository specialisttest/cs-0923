﻿namespace LINQProject
{
    internal class Program
    {

        static IEnumerable<Course> GetCourses()
        {
            yield return new Course("C# 12", 40);
            yield return new Course("Java 1", 40);
            yield return new Course("JavaScript", 24);
            yield return new Course("Pattern OOP", 24);
            yield return new Course("Git", 16);
        }
        
        static void Main(string[] args)
        {
            // Запрос не выполняется сразу, пока не будет вызван GetEnumerator()!!!
            // Deffered excution
            var result =
                from c in GetCourses()
                where c.Length > 30
                orderby c.Title
                select c;
            //select new { CourseTitle = c.Title };


            //var result = (GetCourses()
            //    .Where(c => c.Length > 30)
            //    .OrderBy(c => c.Title)
            //    .Select(c => c)).ToList();

            foreach (var c in result)
                Console.WriteLine(c);
        }
    }
}
