using System;

class ChessBoardGame
{
    static void Main()
    {
        int sizeOfBoard = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int whiteScore = 0;
        int blackScore = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i >= sizeOfBoard * sizeOfBoard)
            {
                break;
            }

            if (i % 2 == 0 && char.IsUpper(input[i]))
            {
                whiteScore += input[i];
            }
            else if (i % 2 == 0 && char.IsLetterOrDigit(input[i]))
            {
                blackScore += input[i];
            }
            else if (i % 2 != 0 && char.IsUpper(input[i]))
            {
                blackScore += input[i];
            }
            else if (i % 2 != 0 && char.IsLetterOrDigit(input[i]))
            {
                whiteScore += input[i];
            }
        }

        if (whiteScore == blackScore)
        {
            Console.WriteLine("Equal result: {0}", whiteScore);
        }

        else
        {
            if (whiteScore > blackScore)
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(Math.Abs(whiteScore - blackScore));
            }
            else
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(Math.Abs(whiteScore - blackScore));
            }
        }
    }
}