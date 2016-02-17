namespace Assertions.AssertionsUtilities
{
    using System;
    using System.Diagnostics;

    public static class SelectionSortMethod
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
            where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, "The array cannot be empty !");
            Debug.Assert(startIndex >= 0 && startIndex <= arr.Length - 1, "THe chosen start index is invalid !");
            Debug.Assert(endIndex >= 0 && endIndex <= arr.Length - 1, "The chosen end index is invalid !");
            Debug.Assert(startIndex <= endIndex, "The start index cannot be after the end index !");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(minElementIndex >= 0 && minElementIndex >= arr.Length - 1, "The index returned is invalid !");
            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}