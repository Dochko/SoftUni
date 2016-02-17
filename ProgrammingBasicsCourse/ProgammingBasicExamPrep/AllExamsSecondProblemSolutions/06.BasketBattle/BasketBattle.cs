using System;

class BasketBattle
{
    static void Main()
    {
        string firstPlayer = Console.ReadLine();
        int numberOfRounds = int.Parse(Console.ReadLine());

        int simeonPoints = 0;
        int nakovPoints = 0;

        bool nakovFirst = false;
        bool simeonFirst = false;

        string winner = "";
        int winRound = 0;

        if (firstPlayer == "Nakov")
        {
            nakovFirst = true;
        }
        else if (firstPlayer == "Simeon")
        {
            simeonFirst = true;
        }

        for (int round = 1; round <= numberOfRounds; round++)
        {
            int firstPoints = int.Parse(Console.ReadLine());
            string firstSuccesfulShot = Console.ReadLine();

            if (simeonFirst)
            {
                if (firstSuccesfulShot == "success" && simeonPoints + firstPoints <= 500)
                {
                    simeonPoints = simeonPoints + firstPoints;
                    if (simeonPoints == 500)
                    {
                        winner = "Simeon";
                        winRound = round;
                        break;
                    }
                }
                

                int secondPoints = int.Parse(Console.ReadLine());
                string secondSuccesfulShot = Console.ReadLine();

                if (secondSuccesfulShot == "success" && nakovPoints + secondPoints <= 500)
                {
                    nakovPoints = nakovPoints + secondPoints;

                    if (nakovPoints == 500)
                    {
                        winner = "Nakov";
                        winRound = round;
                        break;
                    }
                }
            }

            if (nakovFirst)
            {
                if (firstSuccesfulShot == "success" && nakovPoints + firstPoints <= 500)
                {
                    nakovPoints = nakovPoints + firstPoints;
                }
                if (nakovPoints == 500)
                {
                    winner = "Nakov";
                    winRound = round;
                    break;
                }

                int secondPoints = int.Parse(Console.ReadLine());
                string secondSuccesfulShot = Console.ReadLine();

                if (secondSuccesfulShot == "success" && simeonPoints + secondPoints <= 500)
                {
                    simeonPoints = simeonPoints + secondPoints;
                    if (simeonPoints == 500)
                    {
                        winner = "Simeon";
                        winRound = round;
                        break;
                    }
                }

            }

            nakovFirst = !nakovFirst;
            simeonFirst = !simeonFirst;
        }

        if (winner == "Nakov")
        {
            Console.WriteLine(winner);
            Console.WriteLine(winRound);
            Console.WriteLine(simeonPoints);
        }
        else if (winner == "Simeon")
        {
            Console.WriteLine(winner);
            Console.WriteLine(winRound);
            Console.WriteLine(nakovPoints);
        }
        else if (winner == String.Empty && nakovPoints == simeonPoints)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(nakovPoints);
        }
        else
        {
            if (nakovPoints > simeonPoints)
            {
                Console.WriteLine("Nakov");
                Console.WriteLine(nakovPoints - simeonPoints);
            }
            else
            {
                Console.WriteLine("Simeon");
                Console.WriteLine(simeonPoints - nakovPoints);
            }
        }
    }
}