using System;

class ArithmeticOperators
{
    static void Main()
    {
        //+, -, *, /, %, =
        int squarePerimeter = 17;
        double squareSide = squarePerimeter / 4.0;
        double sqareArea = squareSide * squareSide;
        Console.WriteLine("Square Side = {0}" ,squareSide); //4.25
        Console.WriteLine("Square Area = {0}", sqareArea); // 18.0625
        Console.WriteLine();
        
        int a = 5;
        int b = 4;
        Console.WriteLine("a + b = {0}", a + b); // 9
        Console.WriteLine("a + b++ = {0}", a + b++); // 9
        Console.WriteLine("a + b = {0}", a + b); // 10
        Console.WriteLine("a + (++b) = {0}", a + (++b)); // 11
        Console.WriteLine("a + b = {0}", a + b); // 11
        Console.WriteLine();
        
        Console.WriteLine("12 / 3 = {0}", 12 / 3); // 4
        Console.WriteLine("11 / 3 = {0}", 11 / 3); // 3
        Console.WriteLine("11.0 / 3 = {0}", 11.0 / 3); // 3.666666667
        Console.WriteLine("11 / 3.0 = {0}", 11 / 3.0); // 3.666666667
        Console.WriteLine("11 % 3 = {0}", 11 % 3); // 2
        Console.WriteLine("11 % -3 = {0}", 11 % -3); // 2
        Console.WriteLine("-11 % 3 = {0}", -11 % 3); // -2
        Console.WriteLine();

        Console.WriteLine("1.5 / 0.0 = {0}", 1.5 / 0.0); // Infinity
        Console.WriteLine("-1.5 / 0.0 = {0}", -1.5 / 0.0); // -Infinity
        Console.WriteLine("0.0 / 0.0 = {0}", 0.0 / 0.0); // NaN
        Console.WriteLine();

        int bigNum = 2000000000;
        int bigSum = 2 * bigNum; // Integer overflow!
        Console.WriteLine("2000000000 * 2 = {0}", bigSum);

        bigNum = Int32.MaxValue;
        bigNum = bigNum + 1;
        Console.WriteLine("Int max value + 1 = {0}", bigNum);
        Console.WriteLine();

        //Arithmetic operators practice 1
        int varA = int.Parse(Console.ReadLine());
        int varB = int.Parse(Console.ReadLine());
        int varC = int.Parse(Console.ReadLine());
        double average = (varA + varB + varC) / 3.0;
        Console.WriteLine("Average of A, B and C is: {0}", average);
        Console.WriteLine();

        //Arithmetic operators practice 2
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The area of trapezoid is: {0}", area);
        Console.WriteLine();

        //Arithmetic operators practice 3
        int n = int.Parse(Console.ReadLine());
        int lastDigit = n % (10);
        Console.WriteLine("The last number of N is: {0}", lastDigit);

        //Arithmetic operatos practice 4
        int number = int.Parse(Console.ReadLine());
        int nth = int.Parse(Console.ReadLine());
        int power = (int)Math.Pow(10, (nth - 1));
        int nDigit = number / power %(10);
        if (nDigit != 0)
        {
            Console.WriteLine(nDigit);
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}