using System;

class TicTacToePower
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int num = int.Parse(Console.ReadLine());

        long result = 0;
        int position = x + 1;
        if (y == 1)
        {
            position = x + 4;
        }
        else if (y == 2)
        {
            position = x + 7;
        }

        num += position - 1;
        result = (long) Math.Pow(num, position);
        Console.WriteLine(result);
    }
}