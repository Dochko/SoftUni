using System;

class RockLq
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}",
            new string('.', size),
            new string('*', size));

        int outerDotsUpper = size - 2;
        int innerDotsUpper = size + 2;

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', outerDotsUpper),
                new string('.', innerDotsUpper));
            outerDotsUpper -= 2;
            innerDotsUpper += 4;
        }

        Console.WriteLine("*{0}*{1}*{0}*",
            new string('.', size - 2),
            new string('.', size));

        int sleeveDots = ((size * 3) - (size + 8)) / 2;
        int innerSleeveDots = 1;

        for (int i = 0; i < size / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                new string('.', sleeveDots),
                new string('.', innerSleeveDots),
                new string('.', size));
            sleeveDots -= 2;
            innerSleeveDots += 2;
        }

        int outerDotsLower = size - 1;
        int innerDotsLower = size;

        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', outerDotsLower),
                new string('.', innerDotsLower));
            outerDotsLower--;
            innerDotsLower += 2;
        }

        Console.WriteLine(new string('*', size * 3));
    }
}