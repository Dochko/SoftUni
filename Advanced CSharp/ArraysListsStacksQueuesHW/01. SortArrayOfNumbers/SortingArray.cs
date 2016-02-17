namespace SortArrayOfNumbers
{
    using System;
    using System.Linq;

    public class SortingArray
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();
            string[] numbersAsString = numbers.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numberArray = new int[numbersAsString.Length];
            for (int i = 0; i < numbersAsString.Length; i++)
            {
                numberArray[i] = int.Parse(numbersAsString[i]);
            }

            int[] numbersSorted = numberArray.OrderBy(i => i).ToArray();

            Console.WriteLine(string.Join(" ", numbersSorted));
        }
    }
}
