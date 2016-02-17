using System;
using System.Numerics;

class UsingDoWhileLoop
{
    static void Main()
    {
        /*
            do
            {
                statements;
            }
            while (condition;)
        
        First executes the loop condition then it checks is it true or false
        */

        //Easier way to calculate factorial is with do..while loop

        /*Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        BigInteger factorial = 1;

        do
        {
            factorial *= n;
            n--;
        }
        while (n > 0);
        Console.WriteLine(factorial);
        */

        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int number = n;
        decimal product = 1;
        do
        {
            product *= number;
            number++;
        }
        while (number <= m);
        Console.WriteLine("product [{0}...{1}] = {2}", n, m, product);
    }
}