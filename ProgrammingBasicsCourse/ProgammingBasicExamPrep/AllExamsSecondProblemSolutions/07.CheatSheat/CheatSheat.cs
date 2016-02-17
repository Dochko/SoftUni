using System;

class CheatSheat
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int cStartNumber = int.Parse(Console.ReadLine());
        int rStartNumber = int.Parse(Console.ReadLine());

        for (int row = rStartNumber; row < rStartNumber + r; row++)
        {
            for (int col = cStartNumber; col < cStartNumber + c; col++)
            {
                Console.Write(row * col);

                if (col < rStartNumber + c - 1)
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}