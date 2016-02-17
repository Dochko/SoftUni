namespace LongestIncreasingSequence
{
    using System;

    public class LongestIncreasingSequence
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

            int numberLongest = 0;
            int bestCount = 0;
            int longestCount = 0;

            for (int index = 0; index < numberArray.Length - 1; index++)
            {
                var count = CountSequence(index, numberArray);

                if (count >= bestCount)
                {
                    bestCount = count;
                    int number = index;
                    index += count - 1;
                    
                    PrintSequence(number, bestCount, numberArray);

                    if (bestCount > longestCount)
                    {
                        longestCount = bestCount;
                        numberLongest = number;
                    }

                    bestCount = 0;
                }
            }

            Console.Write("Longest: ");
            PrintSequence(numberLongest, longestCount, numberArray);
        }

        private static void PrintSequence(int number, int bestCount, int[] numberArray)
        {
            for (int index = number; index <= number + bestCount - 1; index++)
            {
                Console.Write("{0} ", numberArray[index]);
            }
            
            Console.WriteLine();
        }

        private static int CountSequence(int number, int[] numberArray)
        {
            int count = 1;
            int endPoint = number + 1;
            int index = number;
            while (numberArray[index] < numberArray[endPoint])
            {
                count++;
                endPoint++;
                index++;
                if (endPoint >= numberArray.Length)
                {
                    break;
                }
            }

            return count;
        }
    }
}