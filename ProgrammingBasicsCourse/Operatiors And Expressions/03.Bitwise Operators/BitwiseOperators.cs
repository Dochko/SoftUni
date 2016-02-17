using System;

class BitwiseOperators
{
    static void Main()
    {
        // |, &, ^, <<, >>, ~
        
        //how to get the bit at positon p from a number n ?
        int number = 291;
        int position = 5;
        Console.WriteLine(Convert.ToString(number , 2).PadLeft(8 , '0'));
        Console.WriteLine(number >> (position & 1));

        //how to set the bit at position p to 0 ?
        Console.WriteLine(number & ~(1 << position) );

        //how to set the bit at position p to 1
        Console.WriteLine(number | (1 << position));

        //how to invert 0 to 1 and vice versa
        Console.WriteLine(number ^ (1 << position));

        //Bitwise operators exercise 1:
        //Write a program that prints the bit at position p of a number.
        int nExc1 = int.Parse(Console.ReadLine());
        int bitAtPosition1 = nExc1 >> 1 & 1;
        Console.WriteLine("Exc 1: {0}", bitAtPosition1); //Console.WriteLine(nExc1 >> 1 & 1);

        //Bitwise operators exercise 2:
        //Write a program that prints the bit at position p of a number.
        int nExc2 = int.Parse(Console.ReadLine());
        int pExc2 = int.Parse(Console.ReadLine());
        int bitAtPositionP = (nExc2 >> pExc2) & 1;
        Console.WriteLine("Exc 2: {0}", bitAtPositionP); //Console.WriteLine((nExc2 >> pExc2) & 1);

        //Bitwise operators exercise 3:
        //Write a program that sets the bit at position p to 0.
        int nExc3 = int.Parse(Console.ReadLine());
        int pExc3 = int.Parse(Console.ReadLine());
        int maskExc3 = ~(1 << pExc3);
        int newNumber = nExc3 & maskExc3;
        Console.WriteLine("Exc 3: {0}", newNumber); // Console.WriteLine(nExc3 & ~(1 << pExc3));

        //Bitwise operators excercie 4:
        //Write a program that inverts the 3 bits from position p
        //to the left with their opposites
        long nExc4 = long.Parse(Console.ReadLine());
        int pExc4 = int.Parse(Console.ReadLine());
        long maskExc4 = ((long)7 << pExc4);
        long result = nExc4 ^ maskExc4;
        Console.WriteLine("Exc 4: {0}", result);
    }
}