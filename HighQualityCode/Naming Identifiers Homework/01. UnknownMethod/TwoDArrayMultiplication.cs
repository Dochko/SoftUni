using System;

namespace TwoDArrayMultiplication
{
    class TwoDArrayMultiplication
    {
        static void Main()
        {
            double[,] firstArray = { { 1, 3 }, { 5, 7 } };
            double[,] secondArray = { { 4, 2 }, { 1, 5 } };
            double[,] product = ArrayMultiplication(firstArray, secondArray);

            for (int i = 0; i < product.GetLength(0); i++)
            {
                for (int j = 0; j < product.GetLength(1); j++)
                {
                    Console.Write(product[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        static double[,] ArrayMultiplication(double[,] firstArray, double[,] secondArray)
        {
            if (firstArray.GetLength(1) != secondArray.GetLength(0))
            {
                throw new Exception("Error!");
            }

            int firstArrayLength = firstArray.GetLength(1);
            double[,] product = new double[firstArray.GetLength(0), secondArray.GetLength(1)];

            for (int i = 0; i < product.GetLength(0); i++)
            {
                for (int j = 0; j < product.GetLength(1); j++)
                {
                    for (int k = 0; k < firstArrayLength; k++)
                    {
                        product[i, j] += firstArray[i, k] * secondArray[k, j];
                    }
                }
            }

            return product;
        }
    }
}