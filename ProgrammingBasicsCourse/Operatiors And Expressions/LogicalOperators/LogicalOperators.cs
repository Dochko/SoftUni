using System;

class LogicalOperators
{
    static void Main()
    {
        // ||, &&, ^, !
        
        // || (or) example
        Console.WriteLine(true || false || false || false); // true
        Console.WriteLine();

        // && (and) example
        Console.WriteLine(true && false); // false
        Console.WriteLine(false && true); // false
        Console.WriteLine(true && true); // true
        Console.WriteLine(true && true && false); // false
        Console.WriteLine(true && false || true); // true
        Console.WriteLine();

        // ^ (xor) example
        Console.WriteLine(true ^ false); // true
        Console.WriteLine(true ^ true); // false
        Console.WriteLine(false ^ false); // false
        Console.WriteLine(false ^ true); // true
        Console.WriteLine(false ^ false || true); // true
        Console.WriteLine(true ^ false && true); // true
        Console.WriteLine(false ^ true || false); // true zashtoto ^ > && > ||
        Console.WriteLine((false && true) ^ true || true); // true
        Console.WriteLine();

        // ! (no) example
        Console.WriteLine(!true); // false
        Console.WriteLine(!false); // true
        Console.WriteLine();

        bool a = false;
        bool b = true;
        Console.WriteLine(5 > 7 ^ (a || b));
        Console.WriteLine();
        
        //Logical operators practice 1
        int nBigAndOdd = int.Parse(Console.ReadLine());
        bool resultBigAndOdd = nBigAndOdd > 20 && nBigAndOdd % 2 != 0;
        Console.WriteLine("Number > 20 & Odd ? {0}", resultBigAndOdd);
        Console.WriteLine();

        //Logical operators practise 2
        int n = int.Parse(Console.ReadLine());
        bool result = (n %(9) == 0 || n %(11) == 0 || n %(13) == 0);
        Console.WriteLine("Is the number divided by 9, 11 or 13 ? {0}", result);
    }
}