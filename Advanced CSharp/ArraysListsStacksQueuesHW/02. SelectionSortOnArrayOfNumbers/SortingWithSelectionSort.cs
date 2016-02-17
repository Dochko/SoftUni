namespace SelectionSortOnArrayOfNumbers
{
    using System;

    public class SortingWithSelectionSort
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

            SelectionSorting(numberArray);

            Console.WriteLine(string.Join(" ", numberArray));
        }

        private static void SelectionSorting(int[] numberArray)
        {
            for (int currentIndex = 0; currentIndex < numberArray.Length - 1; currentIndex++)
            {
                int indexOfMin = currentIndex;

                for (int nextIndex = currentIndex; nextIndex < numberArray.Length; nextIndex++)
                {
                    if (numberArray[indexOfMin] > numberArray[nextIndex])
                    {
                        indexOfMin = nextIndex;
                    }
                }

                int temp = numberArray[currentIndex];
                numberArray[currentIndex] = numberArray[indexOfMin];
                numberArray[indexOfMin] = temp;
            }
        }
    }
}
