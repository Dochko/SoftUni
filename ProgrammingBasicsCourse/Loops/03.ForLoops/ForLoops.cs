using System;

class ForLoops
{
    static void Main()
    {
        /*
            for (initialization(int something = something); test; update)
            {
                statements; (can use integer something here)
            }
            (Cannot use integer something here (out of scope) )
        */

        int n = int.Parse(Console.ReadLine());
        
        /*for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        */

        //Calculating factorial with for loop
        int product = 1;

        for (int i = 2; i <= n; i++)
        {
            product *= i;
        }
        Console.WriteLine(product);

        //Complex for loop
        for (int i = 1, sum = 1; i <= 128; i = i*2, sum += i)
        {
            Console.WriteLine("i={0}, sum={1}" , i, sum);
        }

        //n^m example
        //Calculating n to power m
        int nCalc = int.Parse(Console.ReadLine());
        int mPower = int.Parse(Console.ReadLine());
        decimal result = 1;
        for (int i = 0; i < mPower; i++)
        {
            result *= nCalc;
        }
        Console.WriteLine("n^m = " + result);
    }
}