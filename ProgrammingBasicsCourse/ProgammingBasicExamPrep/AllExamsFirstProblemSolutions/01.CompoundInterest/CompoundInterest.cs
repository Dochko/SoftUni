using System;

class CompoundInterest
{
    static void Main()
    {
        double price = double.Parse(Console.ReadLine());
        int loanPeriod = int.Parse(Console.ReadLine());
        double bankInterest = double.Parse(Console.ReadLine());
        double friendInterest = double.Parse(Console.ReadLine());

        double bankLoan = price * Math.Pow((1 + bankInterest) , loanPeriod);
        double friendLoan = price*(1 + friendInterest);

        if(bankLoan < friendLoan)
        {
            Console.WriteLine("{0:F2} Bank" , bankLoan);
        }
        else
        {
            Console.WriteLine("{0:F2} Friend", friendLoan);
        }
    }
}