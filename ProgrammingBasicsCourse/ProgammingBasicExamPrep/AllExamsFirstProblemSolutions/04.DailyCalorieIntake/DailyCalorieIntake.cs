using System;

class DailyCalorieIntake
{
    static void Main()
    {
        int weightInPounds = int.Parse(Console.ReadLine());
        int heightInInches = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int workouts = int.Parse(Console.ReadLine());

        double kilos = weightInPounds / 2.2d;
        double cm = heightInInches * 2.54d;
        double menBmr = 66.5d + (13.75d * kilos) + (5.003d * cm) - (6.755d * age);
        double womenBmr = 655 + (9.563d * kilos) + (1.850d * cm) - (4.676d * age);
        double dci;

        if (workouts <= 0)
        {
            dci = 1.2d;
        }
        else if (workouts >= 1 && workouts <= 3)
        {
            dci = 1.375d;
        }
        else if (workouts >= 4 && workouts <= 6)
        {
            dci = 1.55d;
        }
        else if (workouts >= 7 && workouts <= 9)
        {
            dci = 1.725d;
        }
        else
        {
            dci = 1.9d;
        }

        if (gender == 'm')
        {
            Console.WriteLine(Math.Floor(menBmr * dci));
        }
        else
        {
            Console.WriteLine(Math.Floor(womenBmr * dci));
        }
    }
}