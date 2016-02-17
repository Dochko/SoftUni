using System;

namespace EnterNumbers
{
    class EnterNums
    {
        static void Main()
        {
            int firstNum;
            try
            {
                firstNum = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
                return;
            }

            int secondNum;
            try
            {
                secondNum = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
                return;
            }

            ReadNumber(firstNum, secondNum);
        }

        public static void ReadNumber(int start, int end)
        {
            try
            {
                if (start < 1 || start > 100 || start > end || end > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Must be a valid integer number !");
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Must be in range [1 ... 100] !");
                return;
            }

            int startNum = start;

            for (int i = 0; i < 10; i++)
            {
                int numer = 0;

                try
                {
                    numer = int.Parse(Console.ReadLine());

                    if (numer < start || numer > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else if (numer <= startNum)
                    {
                        throw new ArgumentException();
                    }
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Invalid number !");
                    return;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine("The number must be higher than start number and lower than end number!");
                    i = i - 1;
                }
                catch (ArgumentException)
                {
                    Console.Error.WriteLine("Do it again !");
                    i = i - 1;
                }

                startNum = numer;
            }
        }
    }
}
