namespace InheritanceAndPolymorphism
{
    using System;
    using Contracts;
    using Courses;

    /// <summary>
    /// A demo of the Course, LocalCource and OffsiteCourse classes.
    /// </summary>
    public class CoursesExamples
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            ICourse localCourse = new LocalCourse("Databases", "Svetlin Nakov", "Enterprise");
            Console.WriteLine(localCourse);

            localCourse.Students.Add("Peter");
            localCourse.Students.Add("Maria");
            Console.WriteLine(localCourse);

            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            ICourse offsiteCourse = new OffsiteCourse("PHP and WordPress Development", "Mario Peshev");

            offsiteCourse.Students.Add("Thomas");
            offsiteCourse.Students.Add("Ani");
            offsiteCourse.Students.Add("Steve");
            Console.WriteLine(offsiteCourse);
        }
    }
}