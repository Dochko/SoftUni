namespace RotatingWalkInMatrix
{
    using System;

    public class WalkInMatrix
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number: ");

            try
            {
                int matrixSize = int.Parse(Console.ReadLine());

                if (matrixSize < 1 || matrixSize > 100)
                {
                    throw new ArgumentOutOfRangeException("matrixSize", "Input must be integer number in range [1 ... 100].");
                }

                int[,] matrix = GenerateMatrix(matrixSize);

                PrintMatrix(matrix);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Error.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Input must be integer number in range [1 ... 100].");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Input must be integer number in range [1 ... 100].");
            }
        }

        public static int[,] GenerateMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            int x = 0;
            int y = 0;
            int deltaX = 1;
            int deltaY = 1;

            int stepCount = 0;

            while (stepCount < matrix.Length)
            {
                stepCount++;
                matrix[x, y] = stepCount;

                int nextX = x + deltaX;
                int nextY = y + deltaY;

                bool isNextXInRange = 0 <= nextX && nextX < matrix.GetLength(0);
                bool isNextYInRange = 0 <= nextY && nextY < matrix.GetLength(1);
                bool isNextCellOccupied = false;
                bool hasJumpedToNonAdjacentEmptyCell = false;

                if (isNextXInRange && isNextYInRange)
                {
                    isNextCellOccupied = matrix[nextX, nextY] != 0;
                }

                int loopCount = 0;
                while (!isNextXInRange || !isNextYInRange || isNextCellOccupied)
                {
                    ChangeDirection(ref deltaX, ref deltaY);

                    nextX = x + deltaX;
                    nextY = y + deltaY;

                    isNextXInRange = 0 <= nextX && nextX < matrix.GetLength(0);
                    isNextYInRange = 0 <= nextY && nextY < matrix.GetLength(1);

                    if (isNextXInRange && isNextYInRange)
                    {
                        isNextCellOccupied = matrix[nextX, nextY] != 0;
                    }

                    loopCount++;

                    if (loopCount == 7)
                    {
                        SetPositionToFirstEmptyCell(matrix, out x, out y);
                        hasJumpedToNonAdjacentEmptyCell = true;
                        break;
                    }
                }

                if (!hasJumpedToNonAdjacentEmptyCell)
                {
                    x += deltaX;
                    y += deltaY;
                }
            }

            return matrix;
        }

        private static void ChangeDirection(ref int deltaX, ref int deltaY)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int currentDirectionIndex = 0;
            for (int count = 0; count < 8; count++)
            {
                if (directionsX[count] == deltaX && directionsY[count] == deltaY)
                {
                    currentDirectionIndex = count;
                    break;
                }
            }

            if (currentDirectionIndex == 7)
            {
                deltaX = directionsX[0];
                deltaY = directionsY[0];
            }
            else
            {
                deltaX = directionsX[currentDirectionIndex + 1];
                deltaY = directionsY[currentDirectionIndex + 1];
            }
        }

        private static void SetPositionToFirstEmptyCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (arr[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return;
                    }
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}