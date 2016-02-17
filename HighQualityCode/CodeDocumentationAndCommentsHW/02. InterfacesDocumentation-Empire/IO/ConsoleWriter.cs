using System;
using Empire.Contracts;

namespace Empire.IO
{
    public class ConsoleWriter : IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}