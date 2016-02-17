using System;

namespace Persons
{
    class PersonMain
    {
        static void Main()
        {
            PersonInfo personA = new PersonInfo("Ivan" , 26, "ivan@abv.bg");
            PersonInfo personB = new PersonInfo("Ivan" , 26);
            PersonInfo personC = new PersonInfo();

            Console.WriteLine(personA);
            Console.WriteLine(personB);

            Console.Write("Enter name: ");
            personC.Name = Console.ReadLine();
            Console.Write("Enter age: ");
            personC.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter email (optional): ");
            personC.Email = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(personC);
        }
    }
}