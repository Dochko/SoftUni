using System;

class ContinueOperator
{
    static void Main()
    {
        //Sum all odd number in [1...n], not divisors of 7

        string numberAsString = Console.ReadLine();
        int n = int.Parse(numberAsString);
        int sum = 0;
        for (int i = 1; i <= n; i+= 2)
        {
            if(i % 7 == 0)
            {
                continue;
            }
            sum += i;
        }
        Console.WriteLine("sum = {0}", sum);
    }
}
