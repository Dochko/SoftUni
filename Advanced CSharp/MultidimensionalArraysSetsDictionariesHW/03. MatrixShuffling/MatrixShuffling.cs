namespace MatrixShuffling
{
    using System;

    public class MatrixShuffling
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input != "END")
                {
                    var command = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (command[0] == "swap" && command.Length == 5)
                    {
                        int x1 = int.Parse(command[1]);
                        int y1 = int.Parse(command[2]);
                        int x2 = int.Parse(command[3]);
                        int y2 = int.Parse(command[4]);

                        if (ValidateCoordinates(x1, n, x2, y1, m, y2))
                        {
                            string temp = matrix[x1, y1];
                            matrix[x1, y1] = matrix[x2, y2];
                            matrix[x2, y2] = temp;

                            PrintMatrix(matrix);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!"); // in case of wrong coordinates
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private static bool ValidateCoordinates(int x1, int n, int x2, int y1, int m, int y2)
        {
            bool validX1 = x1 >= 0 && x1 < n;
            bool validX2 = x2 >= 0 && x2 < n;
            bool validY1 = y1 >= 0 && y1 < m;
            bool validY2 = y2 >= 0 && y1 < m;

            return validX1 && validX2 && validY1 && validY2;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}