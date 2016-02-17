using System;

class KingOfThieves
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char ch = Char.Parse(Console.ReadLine());

        int chCounterUpper = 1;
        int emptySpaceUpper = size / 2;

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('-', emptySpaceUpper),
                new string(ch , chCounterUpper));
            chCounterUpper += 2;
            emptySpaceUpper--;
        }

        Console.WriteLine(new string(ch , size));

        int chCounterLower = size - 2;
        int emptySpaceLower = 1;

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('-', emptySpaceLower),
                new string(ch , chCounterLower));
            chCounterLower -= 2;
            emptySpaceLower++;
        }
    }
}