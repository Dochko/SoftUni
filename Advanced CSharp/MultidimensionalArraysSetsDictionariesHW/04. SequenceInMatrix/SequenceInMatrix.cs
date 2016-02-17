namespace SequenceInMatrix
{
    using System;

    public class SequenceInMatrix
    {
        public static void Main()
        {
            Console.WriteLine("Auto generated random matrix: \n");
            Random rnd = new Random();
            int n = rnd.Next(4, 6);
            int m = rnd.Next(4, 6);

            string[] srcSeq = { "ha", "ho", "hi", "fo", "xx", "xxx" };
            string[,] matrix = new string[n, m];
            int count = 1;
            int maxSecq = 1;
            string maxValue = string.Empty;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = srcSeq[rnd.Next(6)];
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("{0,4} ", matrix[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count > maxSecq)
                    {
                        maxSecq = count;
                        maxValue = matrix[row, col];
                    }
                }

                count = 1;
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count > maxSecq)
                    {
                        maxSecq = count;
                        maxValue = matrix[row, col];
                    }
                }

                count = 1;
            }

            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > maxSecq)
                {
                    maxSecq = count;
                    maxValue = matrix[row, col];
                }
            }

            count = 1;

            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > maxSecq)
                {
                    maxSecq = count;
                    maxValue = matrix[row, col];
                }
            }

            for (int i = 0; i < maxSecq; i++)
            {
                if (i < maxSecq - 1)
                {
                    Console.Write("{0}, ", maxValue);
                }
                else
                {
                    Console.Write("{0}", maxValue);
                }
            }

            Console.WriteLine();
        }
    }
}