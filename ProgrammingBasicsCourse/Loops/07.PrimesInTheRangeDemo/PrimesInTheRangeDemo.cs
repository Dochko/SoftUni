using System;

class PrimesInTheRangeDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        for (int number = n; number <= m; number++)
        {
            bool prime = true;
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);

            while(divider <= maxDivider)
            {
                if(number % divider == 0)
                {
                    prime = false;
                    break;
                }
                divider++;
            }
            if(prime)
            {
                Console.WriteLine("{0} ", number);
            }
        }
    }
}