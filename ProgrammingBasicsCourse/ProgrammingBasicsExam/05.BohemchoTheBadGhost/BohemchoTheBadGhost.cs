using System;

internal class BohemchoTheBadGhost
{
    private static void Main()
    {
        int mask = 1;
        int score = 0;
        long result = 0;

        for (int i = 0; i < int.MaxValue; i++)
        {
            string floor = Console.ReadLine();

            if (floor == "Stop, God damn it")
            {
                break;
            }

            else
            {
                string[] apparments = Console.ReadLine().Split(' ');

                long floorNumber = Convert.ToInt64(floor);
                int[] appartmentsNumbers = Array.ConvertAll(apparments, int.Parse);

                for (int j = 0; j < appartmentsNumbers.Length; j++)
                {
                    if ((floorNumber & (mask << appartmentsNumbers[j])) != 0)
                    {
                        floorNumber = floorNumber ^ (mask << appartmentsNumbers[j]);
                    }

                    else if ((floorNumber & (mask << appartmentsNumbers[j])) == 0)
                    {
                        floorNumber = (int)floorNumber | (mask << appartmentsNumbers[j]);
                    }
                }

                for (int j = 0; j < appartmentsNumbers.Length; j++)
                {
                    if ((floorNumber & (mask << appartmentsNumbers[j])) != 0)
                    {
                        score++;
                    }
                }

                result += floorNumber;
            }
        }
        Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", score, result);
    }
}