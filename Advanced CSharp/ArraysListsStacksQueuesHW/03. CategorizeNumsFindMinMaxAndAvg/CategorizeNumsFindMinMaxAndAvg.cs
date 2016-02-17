namespace CategorizeNumsFindMinMaxAndAvg
{
    using System;
    using System.Linq;

    public class CategorizeNumsFindMinMaxAndAvg
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();
            string[] numbersAsString = numbers.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            double[] numbersArray = new double[numbersAsString.Length];
            for (int index = 0; index < numbersAsString.Length; index++)
            {
                numbersArray[index] = double.Parse(numbersAsString[index]);
            }

            float[] floatArray = new float[numbersAsString.Length];
            int[] intArray = new int[numbersAsString.Length];

            int floatCounter;
            int intCounter;
            CategorizeArray(numbersArray, floatArray, intArray, out floatCounter, out intCounter);

            Array.Resize(ref floatArray, floatCounter);
            Array.Resize(ref intArray, intCounter);

            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3:F3}, avg: {4:F2}\n",
                string.Join(" ", floatArray),
                floatArray.Min(),
                floatArray.Max(),
                floatArray.Sum(),
                floatArray.Average());

            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                string.Join(" ", intArray),
                intArray.Min(),
                intArray.Max(),
                intArray.Sum(),
                intArray.Average());
        }

        private static void CategorizeArray(
            double[] numbersArray,
            float[] floatArray,
            int[] intArray,
            out int floatCounter,
            out int intCounter)
        {
            floatCounter = 0;
            foreach (double floatNum in numbersArray)
            {
                if (floatNum % 1 != 0)
                {
                    floatArray[floatCounter] = (float)floatNum;
                    floatCounter++;
                }
            }

            intCounter = 0;
            foreach (double intNum in numbersArray)
            {
                if (intNum % 1 == 0)
                {
                    intArray[intCounter] = (int)intNum;
                    intCounter++;
                }
            }
        }
    }
}