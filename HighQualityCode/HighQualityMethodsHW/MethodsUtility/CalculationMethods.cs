namespace Methods.MethodsUtility
{
    using System;

    /// <summary>
    /// Contains methods for calculation.
    /// </summary>
    public static class CalculationMethods
    {
        /// <summary>
        /// Calculates the triangle area by Heron's formula.
        /// </summary>
        /// <param name="a">Triangle side a.</param>
        /// <param name="b">Triangle side b.</param>
        /// <param name="c">Triangle side c.</param>
        /// <returns>Triangle's area.</returns>
        /// <exception cref="ArgumentOutOfRangeException">triangle side;Sides should be positive !</exception>
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("triangle side", "Sides should be positive !");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        /// <summary>
        /// Finds the maximum element in an array.
        /// </summary>
        /// <param name="numbers">Array of numbers.</param>
        /// <returns>The maximum number from the array.</returns>
        /// <exception cref="ArgumentNullException">numbers;The input array cannot be empty !</exception>
        public static int FindMaxNumber(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentNullException("numbers", "The input array cannot be empty !");
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[0])
                {
                    numbers[0] = numbers[i];
                }
            }

            return numbers[0];
        }

        /// <summary>
        /// Calculates the distance between two points.
        /// </summary>
        /// <param name="x1">The x coordinate of the first point.</param>
        /// <param name="y1">The y coordinate of the first point.</param>
        /// <param name="x2">The x coordinate of the second point.</param>
        /// <param name="y2">The y coordinate of the second point.</param>
        /// <returns>The distance between the points.</returns>
        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return distance;
        }

        /// <summary>
        /// Checks if the line crossing the two given points is horizontal.
        /// </summary>
        /// <param name="x1">The x coordinate of the first point.</param>
        /// <param name="x2">The x coordinate of the second point.</param>
        /// <returns>If the line is horizontal - true, otherwise - false.</returns>
        public static bool IsHorizontalLine(double x1, double x2)
        {
            bool isHorizontal = object.Equals(x1, x2);

            return isHorizontal;
        }

        /// <summary>
        /// Checks if the line crossing the two given points is vertical.
        /// </summary>
        /// <param name="y1">The y coordinate of the first point.</param>
        /// <param name="y2">The y coordinate of the second point.</param>
        /// <returns>If the line is vertical - true, otherwise - false.</returns>
        public static bool IsVerticalLine(double y1, double y2)
        {
            bool isVertical = object.Equals(y1, y2);

            return isVertical;
        }
    }
}