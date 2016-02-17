using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class PetarsGame
{
    static void Main()
    {
        ulong startNum = ulong.Parse(Console.ReadLine());
        ulong endNum = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();

        BigInteger sum = 0;

        for (ulong i = startNum; i < endNum; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += i % 5;
            }
        }

        string sumAsString = sum.ToString();
        string digitToReplace;

        if (sum % 2 == 0)
        {
            digitToReplace = sumAsString[0].ToString();
        }
        else
        {
            digitToReplace = sumAsString[sumAsString.Length - 1].ToString();
        }

        sumAsString = sumAsString.Replace(digitToReplace, replacement);

        Console.WriteLine(sumAsString);
    }
}