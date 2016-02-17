using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Integers
{
    static void Main()
    {
        int[] numbers = new int[10];
        Random rnd = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(0, 101);
        }

        foreach (var num in numbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine(Environment.NewLine);

        for (int i = 0; i < 10; i++)
        {
            if (i == 0)
            {
                continue;
            }
            numbers[i] = numbers[i] + numbers[i - 1];
        }

        foreach (var num in numbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine(Environment.NewLine);
    }
}