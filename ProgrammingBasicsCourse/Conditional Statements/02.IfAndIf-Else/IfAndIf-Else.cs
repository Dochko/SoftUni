using System;

class IfAndIfElse
{
    static void Main()
    {
        // if (condition)
        // {
        //      some statement;
        // }
        // else
        // {
        //     another statement;
        // }

        // If it is true, the statement is executed.
        // If it is false, the statement is skipped.

        Console.WriteLine("Enter 2 numbers:");
        int nFirstNum = int.Parse(Console.ReadLine());
        int nSecondNum = int.Parse(Console.ReadLine());

        if (nFirstNum % 2 == 0)
        {
            Console.WriteLine("The first number is even");
        }
        else
        {
            Console.WriteLine("The first number is odd");
        }
        if(nSecondNum % 2 == 1)
        {
            Console.WriteLine("The second number is odd");
        }
        else
        {
            Console.WriteLine("The second number is even");
        }
        if (nSecondNum > nFirstNum)
        {
            Console.WriteLine("The greater number is: {0}", nSecondNum);
        }
        else
        {
            Console.WriteLine("The greater number is: {0}", nFirstNum);
        }
    }
}