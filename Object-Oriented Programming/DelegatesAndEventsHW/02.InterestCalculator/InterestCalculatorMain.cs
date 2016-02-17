using System;

namespace InterestCalculator
{
    class InterestCalculatorMain
    {
        static void Main()
        {
            InterestCalculator compoundInterest = new InterestCalculator(500m, 0.056, 10, GetCompoundInterest);
            Console.WriteLine("{0:F4}", compoundInterest.Balance);

            InterestCalculator simpleInterest = new InterestCalculator(2500m, 0.072, 15, GetSimpleInterest);
            Console.WriteLine("{0:F4}", simpleInterest.Balance);
        }

        public static decimal GetSimpleInterest(decimal money, double interest, int years)
        {
            double interestFactor = 1 + (interest * years);
            decimal balance = money * (decimal)interestFactor;

            return balance;
        }

        public static decimal GetCompoundInterest(decimal money, double interest, int years)
        {
            const int monthsInYear = 12;

            double interestFactorBase = 1 + (interest / monthsInYear);
            int interestFactorPower = years * monthsInYear;

            decimal interestFactor = 1;
            for (int i = 0; i < interestFactorPower; i++)
            {
                interestFactor *= (decimal)interestFactorBase;
            }

            decimal balance = money * interestFactor;

            return balance;
        }
    }
}
