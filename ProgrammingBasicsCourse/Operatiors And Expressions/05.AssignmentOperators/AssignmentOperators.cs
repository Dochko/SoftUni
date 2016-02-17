using System;

class AssignmentOperators
{
    static void Main()
    {
        // =, +=, -=, |=, *=, /=, ...

        int x = 6;
        int y = 4;
        Console.WriteLine(y *= 2); // 8
        int z = y = 3; // y=3 and z=3
        Console.WriteLine(z); // 3
        Console.WriteLine(x |= 1); // 7
        Console.WriteLine(x += 3); // 10
        Console.WriteLine(x /= 2); // 5

    }
}
