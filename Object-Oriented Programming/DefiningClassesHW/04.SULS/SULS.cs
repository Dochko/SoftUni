using System;
using System.Collections.Generic;
using System.Linq;

namespace SULS
{
    public class Program
    {
        public static void Main()
        {

            List<Student> students = new List<Student>
            {
                new Onsite("Todor", "Todorov", 24, "123456", 5.5m, "OOP"),
                new Onsite("Ivan", "Ivanov", 23, "1234568", 5.8m, "OOP"),
                new Online("Dobromir", "Hristov", 24, "234567", 5.65m, "OOP"),
                new Graduate("Petar", "Petrov", 29, "222335", 5.17m),
                new Dropout("Nencho", "Avramov", 20, "131520", "Bad attitude in the forum", 2.01m)
            };

            var currentStudents = students
                                    .Where(st => st is Current)
                                    .OrderBy(st => st.AverageGrade)
                                    .Select(st => new
                                    {
                                        Name = st.FirstName + " " + st.LastName,
                                        Age = st.Age,
                                        ID = st.StudentNumber,
                                        AvrGrade = st.AverageGrade
                                    });

            foreach (var st in currentStudents)
            {
                Console.WriteLine(st);
            }


            Console.WriteLine();

            Dropout ceco = new Dropout("Nencho", "Avramov", 20, "131520", "Bad attitude in the forum", 2.01m);
            ceco.Reapply();

            Console.WriteLine();

            Junior acho = new Junior("Angel", "Georgiev", 28);
            SeniorTrainer nakov = new SeniorTrainer("Svetlin", "Nakov", 35);

            acho.CreateCourse("HTML/CSS/JS");
            acho.CreateCourse("Java Basics");
            Console.WriteLine("Courses that Angel is training: " + String.Join(", ", acho.Courses) + "\n");

            nakov.CreateCourse("OOP");
            nakov.CreateCourse("Advanced Java");
            Console.WriteLine("Courses that Nakov is training: " + String.Join(", ", nakov.Courses) + "\n");
            nakov.DeleteCourse("OOP");
            Console.WriteLine("Courses that Nakov is training: " + String.Join(", ", nakov.Courses));
        }
    }
}

