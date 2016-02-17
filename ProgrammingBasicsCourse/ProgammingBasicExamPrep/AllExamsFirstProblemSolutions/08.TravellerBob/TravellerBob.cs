using System;

class TravellerBob
{
    static void Main()
    {
        string typeOfYear = Console.ReadLine();
        double contractsMonthsPerYear = double.Parse(Console.ReadLine());
        double familyMonthsPerYear = double.Parse(Console.ReadLine());

        double contractMonths = (((contractsMonthsPerYear * 2)) * 3) * 2;
        double familyMonths = ((familyMonthsPerYear * 2)) * 2;
        double normalMonths = ((12 * ( 12 - (contractsMonthsPerYear + familyMonthsPerYear))) * 3) / 5;

        if (typeOfYear == "leap")
        {
            double leapYear = (contractMonths + familyMonths + normalMonths) * 0.05;
            double totalTravels = contractMonths + familyMonths + normalMonths + leapYear;
            Console.WriteLine(Math.Floor(totalTravels));
        }
        else if (typeOfYear == "normal")
        {
            double normalYearTotalTravels = contractMonths + familyMonths + normalMonths;
            Console.WriteLine(Math.Floor(normalYearTotalTravels));
        }
    }
}