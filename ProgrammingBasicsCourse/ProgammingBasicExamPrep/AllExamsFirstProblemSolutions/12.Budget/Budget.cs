using System;

class Budget
{
    static void Main()
    {
        int moneyKiroHave = int.Parse(Console.ReadLine());
        int weekdaysOut = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());

        int totalWeeks = 4;
        int totalDays = 30;

        int normalWeekends = totalWeeks - hometownWeekends;
        int totalWeekdays = totalDays - (hometownWeekends * 2) - (normalWeekends * 2);

        int normalWeekendsExpenses = (normalWeekends * 2) * 20;
        int normalWeekdaysExpenses = (totalWeekdays - weekdaysOut) * 10;
        int weekdaysOutExpenses = weekdaysOut * (int)((moneyKiroHave * 0.03) + 10);
        int moneyKiroHaveLeft = normalWeekdaysExpenses + normalWeekendsExpenses + weekdaysOutExpenses + 150;

        if (moneyKiroHave > moneyKiroHaveLeft)
        {
            Console.WriteLine("Yes, leftover {0}.", moneyKiroHave - moneyKiroHaveLeft);
        }
        else if (moneyKiroHaveLeft > moneyKiroHave)
        {
            Console.WriteLine("No, not enough {0}.", moneyKiroHaveLeft - moneyKiroHave);
        }
        else
        {
            Console.WriteLine("Exact Budget.");
        }
    }
}