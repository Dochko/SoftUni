using System;

namespace SquareRoot
{
    class Sqrt
    {
        static void Main(string[] args)
        {

            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (number > Int32.MaxValue || number < Int32.MinValue)
                {
                    throw new OverflowException();
                }

                Console.WriteLine(Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid nubmer");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
