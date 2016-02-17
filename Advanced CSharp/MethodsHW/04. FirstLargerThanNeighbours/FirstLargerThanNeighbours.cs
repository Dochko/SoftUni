namespace FirstLargerThanNeighbours
{
    using System;
    using LargerThanNeighbours;

    public class FirstLargerThanNeighbours
    {
        public static void Main()
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(IsLargerThanNeighbours(sequenceOne));
            Console.WriteLine(IsLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(IsLargerThanNeighbours(sequenceThree));
        }

        private static int IsLargerThanNeighbours(int[] numbers)
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                if (LargerThanNeighbours.IsLargerThanNeighbours(numbers, index))
                {
                    return index;
                }
            }

            return -1;
        }
    }
}
