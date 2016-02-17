using System;
using System.Collections.Generic;
using System.Linq;

public class SubSetSums
{
    public static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        string numbers = Console.ReadLine();
        string[] numbersAsString = numbers.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numberArray = new int[numbersAsString.Length];
        for (int i = 0; i < numbersAsString.Length; i++)
        {
            numberArray[i] = int.Parse(numbersAsString[i]);
        }

        numberArray = numberArray.Distinct().ToArray();
        List<List<int>> subsList = new List<List<int>>(); 

        int numsOfSubset = 1 << numberArray.Length;

        for (int i = 1; i < numsOfSubset; i++)
        {
            int pos = numberArray.Length - 1;
            int bit = i;
            List<int> subs = new List<int>();

            while (bit > 0)
            {
                if ((bit & 1) == 1)
                {
                    subs.Add(numberArray[pos]);
                }

                bit >>= 1;
                pos--;
            }

            if (subs.Sum() == sum)
            {
                subs.Reverse();
                subsList.Add(subs);
            }
        }

        foreach (var list in subsList)
        {
            Console.WriteLine("{0} = {1}", string.Join(" + ", list), sum);
        }

        if (subsList.Count == 0)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}