using System;

class SummertimeForProgrammers
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int bottleBottom = size * 2;
        int bottleTop = size + 1;
        int height = 3 * size + 1;

        int outside = (bottleBottom - bottleTop) / 2;
        int inside = bottleTop - 2;

        Console.WriteLine("{0}{1}", 
            new string(' ', outside),
            new string('*', bottleTop));

        for (int i = 0; i < size / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*",
                new string(' ', outside), 
                new string(' ', inside));
        }

        for (int i = 0; i < size / 2 - 1; i++)
        {
            outside--;
            inside += 2;
            Console.WriteLine("{0}*{1}*",
                new string(' ', outside),
                new string(' ', inside));
        }

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("{0}{1}{0}", '*',
                new string('.', size * 2 - 2));
        }

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("{0}{1}{0}", '*',
                new string('@', size * 2 - 2));
        }

        Console.WriteLine(new string('*', size * 2));
    }
}