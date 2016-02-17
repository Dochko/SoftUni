using System;

class CurrencyCheck
{
    static void Main()
    {
        double rubles = double.Parse(Console.ReadLine());
        double dollars = double.Parse(Console.ReadLine());
        double euro = double.Parse(Console.ReadLine());
        double levaA = double.Parse(Console.ReadLine());
        double levaB = double.Parse(Console.ReadLine());

        double rublesInLeva = rubles / 100 * 3.5;
        double dollarsInLeva = dollars * 1.5;
        double euroInLeva = euro * 1.95;
        double levaForTwoGames = levaA / 2;

        bool cheapestA = rublesInLeva < dollarsInLeva && rublesInLeva < euroInLeva && rublesInLeva < levaForTwoGames && rublesInLeva < levaB;
        bool cheapestB = dollarsInLeva < rublesInLeva && dollarsInLeva < euroInLeva && dollarsInLeva < levaForTwoGames && dollarsInLeva < levaB;
        bool cheapestC = euroInLeva < rublesInLeva && euroInLeva < dollarsInLeva && euroInLeva < levaForTwoGames && euroInLeva < levaB;
        bool cheapestD = levaForTwoGames < rublesInLeva && levaForTwoGames < dollarsInLeva && levaForTwoGames < euroInLeva && levaForTwoGames < levaB;
        bool cheapestE = levaB < rublesInLeva && levaB < dollarsInLeva && levaB < euroInLeva && levaB < levaForTwoGames;

        if (cheapestA)
        {
            Console.WriteLine("{0:F2}", rublesInLeva);
        }
        else if (cheapestB)
        {
            Console.WriteLine("{0:F2}", dollarsInLeva);
        }
        else if (cheapestC)
        {
            Console.WriteLine("{0:F2}", euroInLeva);
        }
        else if (cheapestD)
        {
            Console.WriteLine("{0:F2}", levaForTwoGames);
        }
        else if (cheapestE)
        {
            Console.WriteLine("{0:F2}", levaB);
        }
    }
}