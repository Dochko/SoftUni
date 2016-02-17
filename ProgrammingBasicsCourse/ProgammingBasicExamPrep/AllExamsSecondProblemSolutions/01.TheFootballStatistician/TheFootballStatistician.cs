using System;

static class TheFootballStatistician
{
    static void Main()
    {
        double paymentInEuro = double.Parse(Console.ReadLine());

        int arsenalPoints = 0;
        int chelseaPoints = 0;
        int evertonPoints = 0;
        int liverpoolPoints = 0;
        int manchesterCityPoints = 0;
        int manchesterUnitedPoints = 0;
        int southamptonPoints = 0;
        int tottenhamPoints = 0;

        int totalMatches = 0;

        while (true)
        {
            string inputLine = Console.ReadLine();

            if (inputLine == "End of the league.")
            {
                break;
            }

            string[] team = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string firstTeam = team[0];
            string secondTeam = team[2];
            string matchResult = team[1];

            if (matchResult == "1")
            {
                switch (firstTeam)
                {
                    case "Arsenal":
                        arsenalPoints += 3;
                        break;
                    case "Chelsea":
                        chelseaPoints += 3;
                        break;
                    case "Everton":
                        evertonPoints += 3;
                        break;
                    case "Liverpool":
                        liverpoolPoints += 3;
                        break;
                    case "ManchesterCity":
                        manchesterCityPoints += 3;
                        break;
                    case "ManchesterUnited":
                        manchesterUnitedPoints += 3;
                        break;
                    case "Southampton":
                        southamptonPoints += 3;
                        break;
                    case "Tottenham":
                        tottenhamPoints += 3;
                        break;
                }
            }

            else if (matchResult == "2")
            {
                switch (secondTeam)
                {
                    case "Arsenal":
                        arsenalPoints += 3;
                        break;
                    case "Chelsea":
                        chelseaPoints += 3;
                        break;
                    case "Everton":
                        evertonPoints += 3;
                        break;
                    case "Liverpool":
                        liverpoolPoints += 3;
                        break;
                    case "ManchesterCity":
                        manchesterCityPoints += 3;
                        break;
                    case "ManchesterUnited":
                        manchesterUnitedPoints += 3;
                        break;
                    case "Southampton":
                        southamptonPoints += 3;
                        break;
                    case "Tottenham":
                        tottenhamPoints += 3;
                        break;
                }
            }

            else if (matchResult == "X")
            {
                switch (firstTeam)
                {
                    case "Arsenal":
                        arsenalPoints += 1;
                        break;
                    case "Chelsea":
                        chelseaPoints += 1;
                        break;
                    case "Everton":
                        evertonPoints += 1;
                        break;
                    case "Liverpool":
                        liverpoolPoints += 1;
                        break;
                    case "ManchesterCity":
                        manchesterCityPoints += 1;
                        break;
                    case "ManchesterUnited":
                        manchesterUnitedPoints += 1;
                        break;
                    case "Southampton":
                        southamptonPoints += 1;
                        break;
                    case "Tottenham":
                        tottenhamPoints += 1;
                        break;
                }

                switch (secondTeam)
                {
                    case "Arsenal":
                        arsenalPoints += 1;
                        break;
                    case "Chelsea":
                        chelseaPoints += 1;
                        break;
                    case "Everton":
                        evertonPoints += 1;
                        break;
                    case "Liverpool":
                        liverpoolPoints += 1;
                        break;
                    case "ManchesterCity":
                        manchesterCityPoints += 1;
                        break;
                    case "ManchesterUnited":
                        manchesterUnitedPoints += 1;
                        break;
                    case "Southampton":
                        southamptonPoints += 1;
                        break;
                    case "Tottenham":
                        tottenhamPoints += 1;
                        break;
                }
            }
            totalMatches++;
        }

        double moneyInLeva = (totalMatches * paymentInEuro) * 1.94;

        Console.WriteLine("{0:F2}lv.", moneyInLeva);
        Console.WriteLine("Arsenal - {0} points.", arsenalPoints);
        Console.WriteLine("Chelsea - {0} points.", chelseaPoints);
        Console.WriteLine("Everton - {0} points.", evertonPoints);
        Console.WriteLine("Liverpool - {0} points.", liverpoolPoints);
        Console.WriteLine("Manchester City - {0} points.", manchesterCityPoints);
        Console.WriteLine("Manchester United - {0} points.", manchesterUnitedPoints);
        Console.WriteLine("Southampton - {0} points.", southamptonPoints);
        Console.WriteLine("Tottenham - {0} points.", tottenhamPoints);
    }
}