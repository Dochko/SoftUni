namespace LargerThanNeighbours
{
    using System;

    public class LargerThanNeighbours
    {
        public static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, index));
            }
        }

        public static bool IsLargerThanNeighbours(int[] numbers, int index)
        {
            bool isLarger = false;

            if (index == 0)
            {
                isLarger = numbers[index] > numbers[index + 1];
            }
            else if (index == numbers.Length - 1)
            {
                isLarger = numbers[index] > numbers[index - 1];
            }
            else if (index > 0 && index < numbers.Length - 1)
            {
                isLarger = numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1];
            }

            return isLarger;
        }
    }
}
