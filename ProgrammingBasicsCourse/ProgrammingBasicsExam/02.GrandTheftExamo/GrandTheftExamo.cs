using System;

class GrandTheftExamo
{
    static void Main()
    {
        int escapeAttempts = int.Parse(Console.ReadLine());

        long thievesSlapped = 0;
        long thievesEscaped = 0;
        long beersDrinkedTotal = 0;
        long beersForPacks = 0;
        long beerPacksDrinked = 0;

        for (int i = 0; i < escapeAttempts; i++)
        {
            long thievesCount = long.Parse(Console.ReadLine());
            long beersDrinked = long.Parse(Console.ReadLine());

            if (thievesCount > 5)
            {
                thievesSlapped += 5;
                thievesEscaped += Math.Abs(thievesCount - 5);
            }
            else if (thievesCount <= 5)
            {
                thievesSlapped = thievesSlapped + thievesCount;
            }
            beersDrinkedTotal += beersDrinked;
            beersForPacks += beersDrinked;

        }

        if (beersDrinkedTotal >= 6)
        {
            beersDrinkedTotal = beersDrinkedTotal % 6;
            beerPacksDrinked = beersForPacks / 6;

            if (beersDrinkedTotal > 6)
            {
                if (beersDrinkedTotal == 7)
                {
                    beersDrinkedTotal -= 2;
                    beerPacksDrinked += 2;
                }
                else if (beersDrinkedTotal == 8)
                {
                    beersDrinkedTotal -= 3;
                    beerPacksDrinked += 2;
                }
                else if (beersDrinkedTotal == 9)
                {
                    beersDrinkedTotal -= 4;
                    beerPacksDrinked += 2;
                }
            }
        }

        Console.WriteLine("{0} thieves slapped.", thievesSlapped);
        Console.WriteLine("{0} thieves escaped.", thievesEscaped);
        Console.WriteLine("{0} packs, {1} bottles.", beerPacksDrinked, beersDrinkedTotal);
    }
}