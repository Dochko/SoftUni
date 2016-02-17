using System;

class PiggyBank
{
    static void Main()
    {
        int priceOfTank = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        int totalDays = 30;
        int totalMonths = 12;

        int normalDaysSaves = (totalDays - partyDays) * 2;
        int partyExpenses = partyDays * 5;
        int totalSaves = normalDaysSaves - partyExpenses;

        if (partyExpenses > normalDaysSaves)
        {
            Console.WriteLine("never");
        }
        else
        {
            int result = (int)Math.Ceiling((double)priceOfTank / totalSaves);
            int yearsNeeded = result / totalMonths;
            int monthsNeeded = result % totalMonths;
            Console.WriteLine("{0} years, {1} months", yearsNeeded, monthsNeeded);
        }
    }
}