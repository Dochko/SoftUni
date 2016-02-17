using System;

class Headphones
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}",
            new string('-', size / 2),
            new string('*', size + 2));

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('-', size / 2),
                new string('-', size));
        }

        int outerLineUpper = size/2 - 1;
        int starUpper = 3;
        int innerLineUpper = size - 2;

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('-', outerLineUpper),
                new string('*', starUpper),
                new string('-', innerLineUpper));
            outerLineUpper--;
            starUpper += 2;
            innerLineUpper -= 2;
        }

        int innerLineLower = 3;
        int starLower = size - 2;

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('-', i + 1),
                new string('*', starLower),
                new string('-', innerLineLower));
            innerLineLower += 2;
            starLower -= 2;
        }
    }
}