using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanStudentAndWorker
{
    class MainProgram
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Ivan", "Shishman", "00AB03"),
                new Student("Petko", "Petkov", "00EI02"),
                new Student("Houmer", "Simpson", "00KP01"),
                new Student("Bart", "Simpson", "00KP04"),
                new Student("Melisa", "Barton", "00LS09"),
                new Student("Mardj", "Simpons", "00KP05"),
                new Student("Toshko", "Chirkata", "01LS01"),
                new Student("Ne se", "Seshtam veche", "02NS00"),
                new Student("Oshte ne", "Se seshtam", "00ON55"),
                new Student("Nai - nakraq", "Svyrshi", "05NS09")
            };

            List<Worker> workers = new List<Worker>
            {
                new Worker("Nasakoto", "Qkata", 800m, 12),
                new Worker("Toaletka", "Hartieva", 950m, 24),
                new Worker("Colikofer", "Kolev", 1200m, 6),
                new Worker("Ne moga", "Veche", 1000m, 16),
                new Worker("Shte se", "Samoubiq", 600m, 10),
                new Worker("Kiro", "Prycha", 550m, 8),
                new Worker("Petio", "Sopola", 1050m, 9),
                new Worker("Na Kuti", "Kiuchecite", 2000m, 4),
                new Worker("Kondio", "I Liq", 4000m, 6),
                new Worker("Emiliq", "Dineva", 8000m, 2)

            };

            var studentsSort = students.OrderBy(st => st.FacultyNumber);

            Console.WriteLine("Students sorted by faculty number:{0}", Environment.NewLine);

            foreach (var student in studentsSort)
            {
                Console.WriteLine(student);
            }

            var workersSort = workers.OrderByDescending(work => work.MoneyPerHour());

            Console.WriteLine("Workers sorted by money per hour:{0}", Environment.NewLine);

            foreach (var worker in workersSort)
            {
                Console.WriteLine(worker);
            }

            var studentsList = students.Select(st => new {FirstName = st.FirstName, LastName = st.LastName});
            var workersList = workers.Select(w => new {FirstName = w.FirstName, LastName = w.LastName});

            var mergedList = studentsList.Union(workersList).OrderBy(p => p.FirstName).ThenBy(p => p.LastName);

            Console.WriteLine("Students and workers sorted by name:{0}", Environment.NewLine);

            foreach (var person in mergedList)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }

            Console.WriteLine();
        }
    }
}
