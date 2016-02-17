using System;

class Boat
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int width = size * 2;
        int sailUpper = 1;
        int emptySpaceUpper = size - 1;

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}",
                new string('.', emptySpaceUpper),
                new string('*', sailUpper),
                new string('.', size));
            sailUpper += 2;
            emptySpaceUpper -= 2;
        }

        Console.WriteLine("{0}{1}",
            new string('*', size),
            new string('.', size));

        int sailLower = size - 2;
        int emptySpaceLower = 2;

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}",
                new string('.', emptySpaceLower),
                new string('*', sailLower),
                new string('.', size));
            sailLower -= 2;
            emptySpaceLower += 2;
        }

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', i),
                new string('*', width));
            width -= 2;
        }
    }
}