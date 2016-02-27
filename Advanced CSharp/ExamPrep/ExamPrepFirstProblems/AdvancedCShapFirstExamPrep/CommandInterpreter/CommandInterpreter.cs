namespace CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main()
        {
            string[] array = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgs = command.Split();

                switch (commandArgs[0])
                {
                    case "reverse":
                        int startReverse = int.Parse(commandArgs[2]);
                        int countReverse = int.Parse(commandArgs[4]);
                        bool checkReverse = ValidateStartAndCount(array, startReverse, countReverse);
                        if (checkReverse == false)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        else
                        {
                            Array.Reverse(array, startReverse, countReverse);
                            break;
                        }
                    case "sort":
                        int startSort = int.Parse(commandArgs[2]);
                        int countSort = int.Parse(commandArgs[4]);
                        bool checkSort = ValidateStartAndCount(array, startSort, countSort);
                        if (checkSort == false)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        else
                        {
                            Array.Sort(array, startSort, countSort);
                            break;
                        }

                    case "rollLeft":
                        int rollLeftCount = int.Parse(commandArgs[1]);
                        if (rollLeftCount < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < rollLeftCount; i++)
                            {
                                LeftShift(array);
                            }

                            break;
                        }

                    case "rollRight":
                        int rollRightCount = int.Parse(commandArgs[1]);
                        if (rollRightCount < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < rollRightCount; i++)
                            {
                                RightShift(array);
                            }

                            break;
                        }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        private static bool ValidateStartAndCount(string[] array, int start, int count)
        {
            if (start < 0 || start >= array.Length)
            {
                return false;
            }
            else if (count < 0)
            {
                return false;
            }
            else
            {
                return true;                
            }
        }

        private static void LeftShift(string[] array)
        {
            string first = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            
            array[array.Length - 1] = first;
        }

        private static void RightShift(string[] array)
        {
            string last = array[array.Length - 1];

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = last;
        }
    }
}