using System;

class ComparisonOperators
{
    static void Main()
    {
        // ==, <, >, >=, <=, !=

        int a = 5;
        int b = 4;
        Console.WriteLine(a >= b); // true
        Console.WriteLine(a != b); // true
        Console.WriteLine(a == b); // false
        Console.WriteLine(a == a); // true
        Console.WriteLine(a != ++b); // false
        Console.WriteLine(a > b); // false (because ++b)
        Console.WriteLine();


    }
}