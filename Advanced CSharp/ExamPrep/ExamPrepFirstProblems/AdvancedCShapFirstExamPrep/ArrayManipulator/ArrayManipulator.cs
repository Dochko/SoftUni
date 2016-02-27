namespace ArrayManipulator
{
    using System;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Trim()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] args = input.Split();

                if (args[0] == "end")
                {
                    break;
                }

                switch (args[0])
                {
                    case "exchange":
                        int index = int.Parse(args[1]);

                        if (index < 0 || index >= numbers.Length)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        numbers = Exchange(numbers, index + 1);
                        break;
                    case "max":
                    case "min":
                        Console.WriteLine(GetIndex(numbers, args[0], args[1]));
                        break;
                    case "first":
                    case "last":
                        Console.WriteLine(GetSequence(numbers, args[0], int.Parse(args[1]), args[2]));
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        private static int[] Exchange(int[] numbers, int index)
        {
            return numbers.Skip(index).Concat(numbers.Take(index)).ToArray();
        }

        private static string GetIndex(int[] numbers, string type, string parity)
        {
            int remainder = parity == "even" ? 0 : 1;
            int[] filtered = numbers.Where(n => n % 2 == remainder).ToArray();

            if (!filtered.Any())
            {
                return "No matches";
            }

            return type == "max"
                ? Array.LastIndexOf(numbers, filtered.Max()).ToString()
                : Array.LastIndexOf(numbers, filtered.Min()).ToString();
        }

        private static string GetSequence(int[] numbers, string type, int count, string parity)
        {
            if (count > numbers.Length)
            {
                return "Invalid count";
            }

            int remainder = parity == "even" ? 0 : 1;
            int[] filtered = numbers.Where(n => n % 2 == remainder).ToArray();

            return type == "first"
                       ? "[" + string.Join(", ", filtered.Take(count)) + "]"
                       : "[" + string.Join(", ", filtered.Reverse().Take(count).Reverse()) + "]";
        }
    }
}