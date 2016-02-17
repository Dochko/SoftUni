using System;

class PlaidTowel
{
    static void Main()
    {
        int size = Int32.Parse(Console.ReadLine());
        char background = char.Parse(Console.ReadLine());
        char rhombus = char.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string(background, size),
            new string(rhombus, 1),
            new string(background, size + size - 1));

        int outerBackgroundUpper = size + -1;
        int outerBackgroundSecondUpper = 1;
        int innerBackgroundUpper = size + size - 3;

        for (int i = 1; i < size; i++)
        {
            Console.WriteLine("{0}" + rhombus + "{1}" + rhombus + "{2}" + rhombus + "{1}" + rhombus + "{0}",
                new string(background , outerBackgroundUpper),
                new string(background, outerBackgroundSecondUpper),
                new string(background, innerBackgroundUpper));
            outerBackgroundUpper--;
            outerBackgroundSecondUpper += 2;
            innerBackgroundUpper -= 2;
        }

        int outerBackGroundMiddle = 1;
        int outerBackgroundSecondMiddle = size + size - 3;
        int innerBackgroundMiddle = 1;

        Console.WriteLine(rhombus + "{0}" + rhombus + "{0}" + rhombus,
            new string(background, size + size - 1));

        for (int i = 1; i < size; i++)
        {
            Console.WriteLine("{0}" + rhombus + "{1}" + rhombus + "{2}" + rhombus + "{1}" + rhombus + "{0}",
                new string(background, outerBackGroundMiddle),
                new string(background, outerBackgroundSecondMiddle),
                new string(background, innerBackgroundMiddle));
            outerBackGroundMiddle++;
            outerBackgroundSecondMiddle -= 2;
            innerBackgroundMiddle += 2;
        }

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string(background, size),
            new string(rhombus, 1),
            new string(background, size + size - 1));

        int outerBackgroundLower = size + -1;
        int outerBackgroundSecondLower = 1;
        int innerBackgroundLower = size + size - 3;

        for (int i = 1; i < size; i++)
        {
            Console.WriteLine("{0}" + rhombus + "{1}" + rhombus + "{2}" + rhombus + "{1}" + rhombus + "{0}",
                new string(background, outerBackgroundLower),
                new string(background, outerBackgroundSecondLower),
                new string(background, innerBackgroundLower));
            outerBackgroundLower--;
            outerBackgroundSecondLower += 2;
            innerBackgroundLower -= 2;
        }

        Console.WriteLine(rhombus + "{0}" + rhombus + "{0}" + rhombus,
            new string(background, size + size - 1));

        int outerBackGroundMiddleLower = 1;
        int outerBackgroundSecondMiddleLower = size + size - 3;
        int innerBackgroundMiddleLower = 1;

        for (int i = 1; i < size; i++)
        {
            Console.WriteLine("{0}" + rhombus + "{1}" + rhombus + "{2}" + rhombus + "{1}" + rhombus + "{0}",
                new string(background, outerBackGroundMiddleLower),
                new string(background, outerBackgroundSecondMiddleLower),
                new string(background, innerBackgroundMiddleLower));
            outerBackGroundMiddleLower++;
            outerBackgroundSecondMiddleLower -= 2;
            innerBackgroundMiddleLower += 2;
        }

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string(background, size),
            new string(rhombus, 1),
            new string(background, size + size - 1));

    }
}