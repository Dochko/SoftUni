using System;

class Arrays
{
    static void Main()
    {
        int[] array = {1,2,3,4,5};
        int length = array.Length;
        int[] reversed = new int[length];

        for (int index = 0; index < length; index++)
        {

            reversed[length - index - 1] = array[index];
        }

        for (int index = 0; index < length; index++)
        {
            Console.WriteLine(reversed[index] + " ");
        }
    }
}