using System;

class ForEachLoop
{
    static void Main()
    {
        /*
            foreach (var element in collection)
            {
                statements;
            }
        */

        string[] names = { "Pesho", "Mincho", "Ivan", "Dragan", "Minka" };
        int[] numbers = {231, 31, 10, 7, 35, 61, 88, 9, 3254, 1452, 432 };
        string namee = "Pencho";

        foreach (char character in namee)
        {
            Console.WriteLine(character);
        }
        Console.WriteLine();

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}