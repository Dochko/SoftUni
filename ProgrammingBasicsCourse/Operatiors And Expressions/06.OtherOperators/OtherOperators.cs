using System;

class OtherOperators
{
    static void Main()
    {
        // + (in strings), . (member acccess operator), [] (arraysm indexers
        // and attributes, (), (type) (cast operator), ?: (conditional operator)
        // new (used to create new obejcts, typeof (returns System.Type object),
        // is (checks if an object is compatible with given type)
        
        string first = "First";
        string second = "Second";
        Console.WriteLine(first + second); // FirstSecond
        string output = "The number is : ";
        int number = 5;
        Console.WriteLine(output + number); // The number is : 5

        Console.WriteLine("Hello"[1]); // vzimame bukvata ot pyrva poziciq. broi se ot 0
        Console.WriteLine();

        // b ? x : y - if b is true then the result is x else the result is y

        bool isRaining = true;
        string result = isRaining ? "It is raining" : "It is not raining";
        Console.WriteLine(result);
        Console.WriteLine();

        Console.WriteLine(typeof(Int64));
        Console.WriteLine();

        Console.WriteLine(3.14 is float);
        Console.WriteLine();

        string greeting = "Wazup";
        Console.WriteLine(greeting ?? "No text"); // if greeting == null - No text
    }
}