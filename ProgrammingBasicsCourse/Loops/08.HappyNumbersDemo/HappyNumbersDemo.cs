using System;

class HappyNumbersDemo
{
    static void Main()
    {
        // print all 4 digit numbers which the sum of the first 2 digits is equal to the sum of the last 2 digits


        for (int a = 1; a <= 9; a++)
            for (int b = 0; b <= 9; b++)
                for (int c = 0; c <= 9; c++)
                    for (int d = 0; d <= 9; d++)
                    {
                        if ((a + b) == (c + d))
                        {
                            Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
                        }
                    }
    }
}
