using System;

class Sunlight
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int width = size * 3;

        Console.WriteLine("{0}{1}{0}",
            new string('.', width / 2),
            '*');

        int outerEmptySpaceTop = 1;
        int innerEmptySpaceTop = (width - 4) / 2;

        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",
                new string('.', outerEmptySpaceTop),
                new string('.', innerEmptySpaceTop));
            outerEmptySpaceTop++;
            innerEmptySpaceTop--;
        }

        for (int i = 0; i < size; i++)
        {
            if (i == size / 2)
            {
                Console.WriteLine(new string('*', size * 3));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}",
                new string('.', size),
                new string('*', size));
            }
        }

        int innerEmptySpaceBottom = size / 2;

        for (int i = size - 1; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",
                new string('.', i),
                new string('.', innerEmptySpaceBottom));
            innerEmptySpaceBottom++;
        }

        Console.WriteLine("{0}{1}{0}",
            new string('.', width / 2),
            '*');
    }
}