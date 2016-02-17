using System;
using System.Data;
using System.Linq;

class Arrays
{
    static void Main()
    {
        //Allocating an array of 10 integers
        int[] numbers = new int[10];

        //Assigning values to the array elements:
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
            Console.WriteLine(numbers[i]);
        }

        //Accessing array elements by index:
        numbers[3] = 20;
        numbers[5] = numbers[2] + numbers[7];
        Console.WriteLine(numbers[3]);
        Console.WriteLine(numbers[5]);
        Console.WriteLine();

        //Creating a array
        string[] arrayOfNames = new string[5];

        //Assing values of the array members
        arrayOfNames[0] = "Petio";
        arrayOfNames[1] = "Giuzul";
        arrayOfNames[2] = "Kuzman";
        arrayOfNames[3] = "Toaletka";
        arrayOfNames[4] = "Colikofer";

        //Display the index of given member of the array
        int kuzmanIndex = Array.IndexOf(arrayOfNames, "Kuzman");
        Console.WriteLine("Kuzman index is : {0}", kuzmanIndex);
        Console.WriteLine();

        Console.WriteLine("First element is {0}\nLast element is {1}",
            arrayOfNames.First(), arrayOfNames.Last());
        Console.WriteLine();
        
        //or

        var resultOfLinq = arrayOfNames.Where(s => s.Length > 5).ToArray();
        Console.WriteLine("First element is {0}\nLast element is {1}", resultOfLinq);
        Console.WriteLine();

        //Displaying the array
        Array.Sort(arrayOfNames); // Sort in alphabet order
        for (int i = 0; i < arrayOfNames.Length; i++)
        {
            Console.WriteLine(arrayOfNames[i]);
        }
        Console.WriteLine();

        //or

        Array.Reverse(arrayOfNames); // Reverse the array
        foreach (var name in arrayOfNames)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();

        //or

        string resultForStringNumbers = string.Join(" ", arrayOfNames);
        Console.WriteLine(resultForStringNumbers);

        //Another way to create an array
        string[] arrayOfStringNumbers = new string[5];
        arrayOfStringNumbers[0] = "1";
        arrayOfStringNumbers[1] = "55";
        arrayOfStringNumbers[2] = "-3";
        arrayOfStringNumbers[3] = "14";
        arrayOfStringNumbers[4] = "123";

        var result = arrayOfStringNumbers
            .Select(Int32.Parse)
            .OrderByDescending(n => n)
            .ToArray();

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        //Finding sum, minimum, maximum, first and last element
        int[] arrayInts = new int[5];

        for (int i = 0; i < arrayInts.Length; i++)
        {
            arrayInts[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sum = " + arrayInts.Sum());
        Console.WriteLine("Average = " + arrayInts.Average());
        Console.WriteLine("Min = " + arrayInts.Min());
        Console.WriteLine("Max = " + arrayInts.Max());
        Console.WriteLine("First = " + arrayInts.First());
        Console.WriteLine("Last = " + arrayInts.Last());

        //Multidimensional Arrays
        //Alphabet matrix
        int width = 5;
        int height = 5;
        char[,] matrix = new char[height, width]; //[,] is for two dimensional array
        char letter = 'A';

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = letter;
                Console.Write(matrix[row , col]);
                letter++;
            }
            Console.Write(Environment.NewLine);
        }
        Console.WriteLine();

        //Names matrix
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] names = new string[rows , cols];
        for (int row = 0; row < names.GetLength(0); row++) //GetLength(0) is for rows
        {
            for (int col = 0; col < names.GetLength(1); col++) //GetLength(1) is for colums
            {
                Console.Write("names [{0} , {1}] : ", row, col);
                names[row, col] = Console.ReadLine();
            }
        }

        for (int row = 0; row < names.GetLength(0); row++)
        {
            for (int col = 0; col < names.GetLength(1); col++)
            {
                Console.Write("{0} ", names[row , col]);
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}