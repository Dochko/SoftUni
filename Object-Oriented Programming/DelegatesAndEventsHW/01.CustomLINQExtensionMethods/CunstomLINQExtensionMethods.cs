using System;
using System.Collections.Generic;

namespace CustomLINQExtensionMethods
{
    class CunstomLINQExtensionMethods
    {
        static void Main()
        {
            //WhereNot example
            List<int> nums = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var filteredCollection = nums.WhereNot(num => num % 2 == 0);
            Console.WriteLine(string.Join(", ", filteredCollection));


            List<Student> students = new List<Student>
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5)
            };

            //Max and Min examples

            //Max by name and grade
            Console.WriteLine(students.Max(student => student.Name));
            Console.WriteLine();
            Console.WriteLine(students.Max(student => student.Grade));
            Console.WriteLine();

            //Min by name and grade
            Console.WriteLine(students.Min(student => student.Name));
            Console.WriteLine();
            Console.WriteLine(students.Min(student => student.Grade));
            Console.WriteLine();

            //Max student by name and grade
            Console.WriteLine(students.MaxStudent(student => student.Name));
            Console.WriteLine(students.MaxStudent(student => student.Grade));
            Console.WriteLine();

            //Min student by name and grade
            Console.WriteLine(students.MinStudent(student => student.Name));
            Console.WriteLine(students.MinStudent(student => student.Grade));
            Console.WriteLine();
        }
    }
}
