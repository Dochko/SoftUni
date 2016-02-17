using System;


class ConsoleInAndOutExercise
{
    static void Main()
    {
        Console.Write("Integer number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Float number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Float number c: ");
        float c = float.Parse(Console.ReadLine());
        string binary = Convert.ToString(a, 2);
        Console.WriteLine("|{0,-15:X} |{1}| {2,10}|{3,-10:F3}|", a, binary.PadLeft(10,'0'), b ,c);
    }
}