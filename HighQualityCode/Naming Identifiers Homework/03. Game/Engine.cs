using System;
using System.Collections.Generic;

namespace Minesweeper
{
    public static class Engine
    {
        public static void Run(bool gameStart, char[,] board, int row, int col, List<Player> hallOfFame,
            char[,] bombs, bool foundBomb, int counter, int counterMax, bool gameEnd)
        {
            string command = String.Empty;

            do
            {
                if (gameStart)
                {
                    Console.Clear();
                    Console.WriteLine(
                        "Lets play \"Minesweeper\"! The goal is to find all squares without mines." +
                        " The commands are - \"top\" to see Hall of Fame, \"restart\" starts new game and \"exit\" quits the game!");
                    BoardDraw(board);
                    gameStart = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (Int32.TryParse(command[0].ToString(), out row) && Int32.TryParse(command[2].ToString(), out col)
                        && row <= board.GetLength(0) && col <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        HallOfFame(hallOfFame);
                        break;
                    case "restart":
                        Restart(out board, out gameStart, out bombs, out foundBomb, out counter);
                        break;
                    case "exit":
                        Console.WriteLine("Bye !");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                PlayerTurn(board, bombs, row, col);
                                counter++;
                            }

                            if (counterMax == counter)
                            {
                                gameEnd = true;
                            }

                            else
                            {
                                BoardDraw(board);
                            }
                        }

                        else
                        {
                            foundBomb = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nUnknow command\n");
                        break;
                }

                if (foundBomb)
                {
                    BoardDraw(bombs);
                    StepOnBomb(hallOfFame, counter);
                    Restart(out board, out gameStart, out bombs, out foundBomb, out counter);
                }

                if (gameEnd)
                {
                    Console.WriteLine("\nCongratulations ! You found all the bombs !");
                    BoardDraw(bombs);
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Player points = new Player(name, counter);
                    hallOfFame.Add(points);
                    HallOfFame(hallOfFame);
                    Restart(out board, out gameStart, out bombs, out foundBomb, out counter);
                }
            } while (command != "exit");

            Console.WriteLine("Made by SoftUni !");
            Console.WriteLine("Thanks for the awful code guys.");
            Console.Read();
        }

        private static void Restart(out char[,] board, out bool gameStart, out char[,] bombs, out bool foundBomb,
            out int counter)
        {
            board = CreatePlayingField();
            bombs = PopulateBombs();
            counter = 0;
            foundBomb = false;
            gameStart = true;
        }

        private static void StepOnBomb(List<Player> hallOfFame, int counter)
        {
            Console.Write("\nYou stepped on a bomb and died with {0} points.\n" + "Enter your name: ", counter);
            string name = Console.ReadLine();
            Player player = new Player(name, counter);

            if (hallOfFame.Count < 5)
            {
                hallOfFame.Add(player);
            }

            else
            {
                for (int i = 0; i < hallOfFame.Count; i++)
                {
                    if (hallOfFame[i].Points < player.Points)
                    {
                        hallOfFame.Insert(i, player);
                        hallOfFame.RemoveAt(hallOfFame.Count - 1);
                        break;
                    }
                }
            }

            hallOfFame.Sort((player1, player2) => string.Compare(player2.Name, player1.Name, StringComparison.Ordinal));
            hallOfFame.Sort((player1, player2) => player2.Points.CompareTo(player1.Points));
            HallOfFame(hallOfFame);
        }

        public static void HallOfFame(List<Player> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Hall of Fame is empty !\n");
            }
        }

        public static void PlayerTurn(char[,] board, char[,] bombs, int row, int col)
        {
            char bombsQuantity = BombsQuantity(bombs, row, col);
            bombs[row, col] = bombsQuantity;
            board[row, col] = bombsQuantity;
        }

        public static void BoardDraw(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        public static char[,] CreatePlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        public static char[,] PopulateBombs()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> bombList = new List<int>();

            while (bombList.Count < 15)
            {
                Random randomNumber = new Random();
                int randomBombPosition = randomNumber.Next(50);

                if (!bombList.Contains(randomBombPosition))
                {
                    bombList.Add(randomBombPosition);
                }
            }

            foreach (int bombPosition in bombList)
            {
                int col = bombPosition / boardColumns;
                int row = bombPosition % boardColumns;
                if (row == 0 && bombPosition != 0)
                {
                    col--;
                    row = boardColumns;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        public static void TotalMinelessSquares(char[,] board)
        {
            int col = board.GetLength(0);
            int row = board.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char quantity = BombsQuantity(board, i, j);
                        board[i, j] = quantity;
                    }
                }
            }
        }

        public static char BombsQuantity(char[,] board, int col, int row)
        {
            int quantity = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (col - 1 >= 0)
            {
                if (board[col - 1, row] == '*')
                {
                    quantity++;
                }
            }

            if (col + 1 < rows)
            {
                if (board[col + 1, row] == '*')
                {
                    quantity++;
                }
            }

            if (row - 1 >= 0)
            {
                if (board[col, row - 1] == '*')
                {
                    quantity++;
                }
            }

            if (row + 1 < cols)
            {
                if (board[col, row + 1] == '*')
                {
                    quantity++;
                }
            }

            if ((col - 1 >= 0) && (row - 1 >= 0))
            {
                if (board[col - 1, row - 1] == '*')
                {
                    quantity++;
                }
            }

            if ((col - 1 >= 0) && (row + 1 < cols))
            {
                if (board[col - 1, row + 1] == '*')
                {
                    quantity++;
                }
            }

            if ((col + 1 < rows) && (row - 1 >= 0))
            {
                if (board[col + 1, row - 1] == '*')
                {
                    quantity++;
                }
            }

            if ((col + 1 < rows) && (row + 1 < cols))
            {
                if (board[col + 1, row + 1] == '*')
                {
                    quantity++;
                }
            }

            return char.Parse(quantity.ToString());
        }
    }
}