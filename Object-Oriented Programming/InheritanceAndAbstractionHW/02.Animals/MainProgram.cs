using System;
using System.Linq;
using Animals.AnimalTypes;

namespace Animals
{
    class MainProgram
    {
        static void Main()
        {
            Animal[] dogArray = new Animal[5];
            dogArray[0] = new Dog("Sharo", 4, "male");
            dogArray[1] = new Dog("Rex", 1, "male");
            dogArray[2] = new Dog("Lasi", 10, "male");
            dogArray[3] = new Dog("Djinka", 3, "female");
            dogArray[4] = new Dog("Princess", 2, "female");

            foreach (var animal in dogArray)
            {
                Console.WriteLine(animal);
            }

            var dogArrayAvg = dogArray.Average(d => d.Age);
            Console.WriteLine("Average dog age: {0:F2}{1}",dogArrayAvg, Environment.NewLine);
            Console.WriteLine();


            Cat[] catArray = new Cat[5];
            catArray[0] = new Kitten("Mici", 3);
            catArray[1] = new Tomcat("Tom", 5);
            catArray[2] = new Kitten("Grozdanka", 2);
            catArray[3] = new Tomcat("Grozdan", 10);
            catArray[4] = new Kitten("Micana", 7);

            foreach (var cat in catArray)
            {
                Console.WriteLine(cat);
            }

            var catArrayAvg = catArray.Average(c => c.Age);
            Console.WriteLine("Average cat age: {0:F2}{1}",catArrayAvg, Environment.NewLine);
            Console.WriteLine();


            Frog[] frogArray = new Frog[5];
            frogArray[0] = new Frog("Kyrmit", 4, "male");
            frogArray[1] = new Frog("Kyrmita", 2, "female");
            frogArray[2] = new Frog("Kyrmin", 6, "male");
            frogArray[3] = new Frog("Kyrmina", 3, "female");
            frogArray[4] = new Frog("Kyrtin", 8, "male");

            foreach (var frog in frogArray)
            {
                Console.WriteLine(frog);
            }

            var frogArrayAvg = frogArray.Average(f => f.Age);
            Console.WriteLine("Average frog age: {0:F2}{1}", frogArrayAvg, Environment.NewLine);
            Console.WriteLine();
        }
    }
}
