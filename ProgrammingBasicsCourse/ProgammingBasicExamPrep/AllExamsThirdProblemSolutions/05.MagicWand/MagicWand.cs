using System;

class MagicWand
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int width = 3 * size + 2;

        Console.WriteLine("{0}*{0}",
            new string('.', width / 2));

        int middleDotCounterUpper = 1;
        int outerDotCounterUpper = (size*3 - 1) / 2;

        for (int i = 0; i < size / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', outerDotCounterUpper),
                new  string('.', middleDotCounterUpper));
            outerDotCounterUpper--;
            middleDotCounterUpper += 2;
        }

        Console.WriteLine("{0}{1}{0}",
            new string('*', size),
            new string('.', size + 2));

        int middleDotCounterMiddle = size * 3 - 2;

        for (int i = 1; i <= size / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', i),
                new string('.', middleDotCounterMiddle));
            middleDotCounterMiddle -= 2;
        }

        int outerMiddleDots = size / 2 - 1;

        for (int i = 1; i <= size / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}",
                new string('.', outerMiddleDots),
                new string('.', size / 2),
                new string('.', i - 1),
                new string('.', size));

            outerMiddleDots--;
        }

        Console.WriteLine("{0}{1}*{2}*{1}{0}",
            new string('*', size / 2 + 1),
            new string('.', size / 2),
            new string('.', size));

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("{0}*{0}*{0}",
                new string('.', size));
        }

        Console.WriteLine("{0}{1}{0}",
            new string('.', size),
            new string('*', size + 2));
    }
}