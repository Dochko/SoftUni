using System;

class BookProblem
{
    static void Main()
    {
        int bookPages = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int stefanReadedPages = int.Parse(Console.ReadLine());

        int totalYMonths = 12;
        int totalDays = 30;

        if (campingDays == 30 || stefanReadedPages == 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            int normalDaysInMonth = totalDays - campingDays;
            int pagesReadPerMonth = stefanReadedPages*normalDaysInMonth;

            int totalMonthNeeded = (int) Math.Ceiling((double) bookPages/pagesReadPerMonth);

            int yearsNeeded = totalMonthNeeded/totalYMonths;
            int monthsNeeded = totalMonthNeeded%totalYMonths;

            Console.WriteLine("{0} years {1} months", yearsNeeded , monthsNeeded);
        }   
    }
}