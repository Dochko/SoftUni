using System;

class FourFactors
{
    static void Main()
    {
        int fieldGoals = int.Parse(Console.ReadLine());
        int fieldGoalAttempts = int.Parse(Console.ReadLine());
        int threePointFieldGoals = int.Parse(Console.ReadLine());
        int turnovers = int.Parse(Console.ReadLine());
        int offensiveRebounds = int.Parse(Console.ReadLine());
        int opponentDefRebounds = int.Parse(Console.ReadLine());
        int freeThrows = int.Parse(Console.ReadLine());
        int freeThrowsAttempts = int.Parse(Console.ReadLine());

        double effectiveFieldGoalPercentage = (fieldGoals + 0.5 * threePointFieldGoals) / fieldGoalAttempts;
        double turnoverPersentage = turnovers / (fieldGoalAttempts + 0.44 * freeThrowsAttempts + turnovers);
        double offensiveReboundingPercentage = offensiveRebounds / (offensiveRebounds + (double) opponentDefRebounds);
        double freeThrowPercentage = (double)freeThrows / fieldGoalAttempts;

        Console.WriteLine("eFG% {0:F3}", effectiveFieldGoalPercentage);
        Console.WriteLine("TOV% {0:F3}", turnoverPersentage);
        Console.WriteLine("ORB% {0:F3}", offensiveReboundingPercentage);
        Console.WriteLine("FT% {0:F3}", freeThrowPercentage);
    }
}