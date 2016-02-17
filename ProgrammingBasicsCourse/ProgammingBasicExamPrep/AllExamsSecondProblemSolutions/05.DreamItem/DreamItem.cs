using System;

class DreamItem
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        string month = input[0];
        decimal moneyPerHour = decimal.Parse(input[1]);
        int hours = int.Parse(input[2]);
        decimal itemPrice = decimal.Parse(input[3]);

        int days = 0;

        switch (month)
        {
            case "Feb": days = 28; break;
            case "Apr":
            case "June":
            case "Sept":
            case "Nov": days = 30; break;
            default: days = 31; break;
        }

        days -= 10;

        decimal moneyEarned = days * moneyPerHour * hours;

        if (moneyEarned > 700)
        {
            moneyEarned += moneyEarned * 0.1m;
        }

        if (moneyEarned >= itemPrice)
        {
            Console.WriteLine("Money left = {0:F2} leva.", moneyEarned - itemPrice);
        }

        else
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", itemPrice - moneyEarned);
        }
    }
}