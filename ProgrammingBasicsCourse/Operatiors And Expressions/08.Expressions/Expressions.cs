using System;

class Expressions
{
    static void Main()
    {
        int r = (150 - 20) / 2 + 5; // r = 70

        //Expression for calculating a circle area
        double surface = Math.PI * r * r;

        //Expression for calculating a circle perimeter
        double perimeter = 2 * Math.PI * r;

        int a = 2 + 3; // a = 5
        int b = (a + 3) * (a - 4) + (2 * a + 7) / 4; //b = 12
        bool greater = (a > b) || ((a == 0) && (b == 0));
        Console.WriteLine(greater);


    }
}