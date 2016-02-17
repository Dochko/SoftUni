using System;
using System.Numerics;

class UsingWhileLoop
{
    static void Main()
    {
        /*
            while (condition)
            {
                statements (loop condition);
            }

            Returns a boolean result of true or false.
            If its true it repeats. If its false it ends.
        */

        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int counter = 1;

        while (counter <= n)
        {
            sum += counter;
            counter++;
            Console.WriteLine("Number : {0}", sum);
        }

        //Prime number check example 1
        /*
        Console.WriteLine("Enter a positive int number: ");
        uint number = uint.Parse(Console.ReadLine());
        uint divider = 2;
        uint maxDivider = (uint)Math.Sqrt(number);
        bool prime = true;
        while (prime && (divider <= maxDivider))
        {
            if (number % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        Console.WriteLine("Prime ? {0}", prime);
        */

        //Prime number check example 2 (easier way)
        Console.WriteLine("Enter a number to check it if it is prime number:");
        uint number = uint.Parse(Console.ReadLine());
        uint divider = 2;
        uint remainder = 0;
        bool isPrime = true;

        while(divider <= number)
        {
            remainder = number % divider;
            divider++;

            if (remainder == 0)
            {
                isPrime = false;
            }
        }
        Console.WriteLine(isPrime);

        //Calculating factorial
        string consoleInputLine = Console.ReadLine();
        int nFactorial = Convert.ToInt32(consoleInputLine);
        Console.Write("n! = ");

        //"decimal" is the biggest integer type
        // You may also try with BigInteger ()from System.Numerics.dll
        BigInteger factorial = 1;

        while(true)
        {
            Console.Write(nFactorial);
            if (nFactorial == 1)
            {
                break;
            }
            Console.Write(" * ");
            factorial *= nFactorial;
            nFactorial--;
        }
        Console.WriteLine(" = {0}", factorial);
    }
}