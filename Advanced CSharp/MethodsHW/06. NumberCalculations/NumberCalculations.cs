namespace NumberCalculations
{
    using System;
    using System.Linq;

    public class NumberCalculations
    {
        public static void Main()
        {
            Console.Write("Enter decimal numbers in one line: ");
            decimal[] decimalNumbers =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse)
                    .ToArray();

            Console.WriteLine(
                "Min: {0}, Max: {1}, Sum: {2}, Average: {3}, Product: {4}{5}",
                GetMin(decimalNumbers),
                GetMax(decimalNumbers),
                GetSum(decimalNumbers),
                GetAverage(decimalNumbers),
                GetProduct(decimalNumbers),
                Environment.NewLine);
            Console.WriteLine();

            Console.Write("Enter double numbers in one line: ");
            double[] doubleNumbers =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

            Console.WriteLine(
                "Min: {0}, Max: {1}, Sum: {2}, Average: {3}, Product: {4}{5}",
                GetMin(doubleNumbers),
                GetMax(doubleNumbers),
                GetSum(doubleNumbers),
                GetAverage(doubleNumbers),
                GetProduct(doubleNumbers),
                Environment.NewLine);
            Console.WriteLine();
        }

        // Min
        private static decimal GetMin(decimal[] numbers)
        {
            decimal min = numbers[0];
            for (int index = 1; index < numbers.Length; index++)
            {
                if (numbers[index] < min)
                {
                    min = numbers[index];
                }
            }

            return min;
        }

        private static double GetMin(double[] numbers)
        {
            double min = numbers[0];
            for (int index = 1; index < numbers.Length; index++)
            {
                if (numbers[index] < min)
                {
                    min = numbers[index];
                }
            }

            return min;
        }

        // Max
        private static decimal GetMax(decimal[] numbers)
        {
            decimal max = numbers[0];
            for (int index = 1; index < numbers.Length; index++)
            {
                if (numbers[index] > max)
                {
                    max = numbers[index];
                }
            }

            return max;
        }

        private static double GetMax(double[] numbers)
        {
            double max = numbers[0];
            for (int index = 1; index < numbers.Length; index++)
            {
                if (numbers[index] > max)
                {
                    max = numbers[index];
                }
            }

            return max;
        }

        // Sum
        private static decimal GetSum(decimal[] numbers)
        {
            decimal sum = numbers[0];
            for (int index = 1; index < numbers.Length; index++)
            {
                sum += numbers[index];
            }

            return sum;
        }

        private static double GetSum(double[] numbers)
        {
            double sum = numbers[0];
            for (int index = 1; index < numbers.Length; index++)
            {
                sum += numbers[index];
            }

            return sum;
        }

        // Average
        private static decimal GetAverage(decimal[] numbers)
        {
            decimal average = GetSum(numbers) / numbers.Length;

            return average;
        }

        private static double GetAverage(double[] numbers)
        {
            double average = GetSum(numbers) / numbers.Length;

            return average;
        }

        // Product
        private static decimal GetProduct(decimal[] numbers)
        {
            decimal product = numbers[0];
            for (int index = 1; index < numbers.Length; index++)
            {
                product *= numbers[index];
            }

            return product;
        }

        private static double GetProduct(double[] numbers)
        {
            double product = numbers[0];
            for (int index = 1; index < numbers.Length; index++)
            {
                product *= numbers[index];
            }

            return product;
        }
    }
}
