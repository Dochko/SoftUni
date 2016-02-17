using System;

class ComparisonAndLogicalOperators
{
    static void Main()
    {
        // Arithmetic Operators: +, -, *, /, %, ++, --
        // Logical: &&, ||, ^, !
        // Comparison: ==, !=, <, >, <=, >=
        // Assignment: =, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=

        // De Morgan Laws:
        // !!A <> A
        // !(A || B) <> !A && !B
        // !(A && B) <> !A || !B
        
        // Example:
        // !(!A && B || !B)
        // !A || !B && B
    }
}
