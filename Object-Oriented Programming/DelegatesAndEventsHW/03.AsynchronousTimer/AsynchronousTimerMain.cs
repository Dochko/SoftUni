using System;

namespace AsynchronousTimer
{
    class AsynchronousTimerMain
    {
        public static void RandomNumber(int num)
        {
            Random rnd = new Random();
            Console.Write("{0} ", rnd.Next(1, 1000));
        }

        public static void AddNewLine(int n)
        {
            Console.WriteLine();
        }

        static void Main()
        {
            AsyncTimer randomNumberPerSecond = new AsyncTimer(RandomNumber, 10, 1000);
            AsyncTimer newLine = new AsyncTimer(AddNewLine, 1, 11000);

            randomNumberPerSecond.Run();
            newLine.Run();
        }
    }
}
