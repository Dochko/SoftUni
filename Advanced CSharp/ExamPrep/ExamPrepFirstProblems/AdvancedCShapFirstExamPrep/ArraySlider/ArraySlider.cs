namespace ArraySlider
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class ArraySlider
    {
        public static void Main()
        {
            BigInteger[] numbers = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            string command = Console.ReadLine();
            int currentIndex = 0;

            while (command != "stop")
            {
                string[] commandArgs = command.Split();
                int offset = int.Parse(commandArgs[0]) % numbers.Length;
    
                if (offset < 0)
                {
                    offset += numbers.Length;
                }

                currentIndex = (currentIndex + offset) % numbers.Length;

                string operation = commandArgs[1];
                int operand = int.Parse(commandArgs[2]);

                PerformOperation(operation, numbers, currentIndex, operand);

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        private static void PerformOperation(string operation, BigInteger[] numbers, int currentIndex, int operand)
        {
            switch (operation)
            {
                case "&":
                    numbers[currentIndex] &= operand;
                    break;
                case "|":
                    numbers[currentIndex] |= operand;
                    break;
                case "^":
                    numbers[currentIndex] ^= operand;
                    break;
                case "+":
                    numbers[currentIndex] += operand;
                    break;
                case "-":
                    numbers[currentIndex] -= operand;
                    break;
                case "*":
                    numbers[currentIndex] *= operand;
                    break;
                case "/":
                    numbers[currentIndex] /= operand;
                    break;
            }

            if (numbers[currentIndex] < 0)
            {
                numbers[currentIndex] = 0;
            }
        }
    }
}