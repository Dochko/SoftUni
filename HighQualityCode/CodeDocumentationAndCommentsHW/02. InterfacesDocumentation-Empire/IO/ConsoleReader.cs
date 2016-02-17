using System;
using Empire.Contracts;

namespace Empire.IO
{
    public class ConsoleReader : IInputReader
    {
        public string ReadCommand()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}