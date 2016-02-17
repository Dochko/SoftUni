using System;
using System.Linq;
using System.Collections.Generic;

class ListsOfElements
{
    static void Main()
    {
        //Creating the list and checking its max length
        Console.WriteLine("Creating the list and checking its max length");
        List<int> numbers = new List<int>();
        Console.WriteLine(numbers.Capacity);
        numbers.Add(5);
        Console.WriteLine(numbers.Capacity);
        numbers.Add(2);
        numbers.Add(5);
        numbers.Add(4);
        numbers.Add(5);
        Console.WriteLine(numbers.Capacity);
        Console.WriteLine();
        Console.WriteLine("The list before: ");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        //Removing a specific number from the list using while loop
        Console.WriteLine("Removing a specific number from the list using while loop");
        Console.WriteLine("The list after: ");
        int index = 0;
        while (index < numbers.Count)
        {
            if (numbers[index] == 5)
            {
                numbers.RemoveAt(index);
            }
            index++;
        }

        //or

        numbers.RemoveAll(n => n == 5); //Faster way to remove a specific number in the list

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();
        
        //Sorting the list
        Console.WriteLine("Sorting the list");
        numbers.Sort();
        numbers.Reverse();
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        //Inserting number in specific position of the list
        Console.WriteLine("Inserting number in specific position of the list");
        numbers.Insert(2, 100);
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Number 100 is in index {0}", numbers.IndexOf(100));
        Console.WriteLine();

        //Add number from the console
        Console.WriteLine("Add number from the console");
        Console.Write("Add a number in the list: ");
        int userInput = int.Parse(Console.ReadLine());
        numbers.Add(userInput);
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        //Creating a list with arrays with loop
        Console.WriteLine("Creating a list with arrays");
        Console.Write("Enter numbers separated with space: ");
        string inputNumbers = Console.ReadLine();
        
        //string[] splitedNumbers = inputNumbers.Split(' ');
        //List<int> listOfNumbers = new List<int>();
        //for (int i = 0; i < splitedNumbers.Length; i++)
        //{
        //    listOfNumbers.Add(int.Parse(splitedNumbers[i]));
        //}

        //or

        //List<string> listOfNumbers = new List<string>(splitedNumbers);

        //or with Linq

        var splitedNumbers = inputNumbers
            .Split(' ')
            .Select(Int32.Parse)
            .ToList();

        foreach (var num in splitedNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        //Example of a list
        Console.WriteLine("Example of a list");

        List<string> names = 
            new List<string>() {"Peter", "Maria", "Katya", "Todor"};
        names.Add("Nakov"); //Peter, Maria, Katya, Todor, Nakov
        names.RemoveAt(0); //Maria, Katya, Todor, Nakov
        names.Insert(3 , "Sylvia"); // Maria, Katya, Todor, Sylvia, Nakov
        names[1] = "Michael"; // Maria, Michael, Todor, Sylvia, Nakov

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();


    }
}