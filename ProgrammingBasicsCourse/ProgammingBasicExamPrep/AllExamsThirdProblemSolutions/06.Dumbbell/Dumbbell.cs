using System;

class Dumbbell
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string('.', size / 2),
            new string('&', size / 2 + 1),
            new string('.', size));

        int outerDotsUpper = size / 2 - 1;
        int middleStarUpper = size / 2;

        for (int i = 0; i < size / 2 - 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                new string('.', outerDotsUpper),
                new string('*', middleStarUpper),
                new string('.', size));
            outerDotsUpper--;
            middleStarUpper++;
        }

        Console.WriteLine("&{0}&{1}&{0}&",
                    new string('*', size - 2),
                    new string('=', size));

        int middleStarLower = ((size*3) - (size + 6)) / 2;

        for (int i = 0; i < size / 2 - 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                new string('.', i + 1),
                new string('*', middleStarLower),
                new string('.', size));
            middleStarLower--;
        }

            Console.WriteLine("{0}{1}{2}{1}{0}",
            new string('.', size / 2),
            new string('&', size / 2 + 1),
            new string('.', size));
    }
}