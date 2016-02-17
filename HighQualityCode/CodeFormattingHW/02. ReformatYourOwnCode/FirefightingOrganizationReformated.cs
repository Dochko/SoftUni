namespace ReformatYourOwnCode
{
    using System;

    //I know its not a big refactoring, but i can find anything worse than that :D
    class FirefightingOrganizationReformated
    {
        static void Main()
        {
            int fireFightersTotal = int.Parse(Console.ReadLine());

            int kidsSaved = 0;
            int adultsSaved = 0;
            int seniorsSaved = 0;
            int fireFightersLeft = fireFightersTotal;

            for (int i = 0; i < 50; i++)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException(nameof(input), "Input cannot be null or empty !");
                }
                else if (input == "rain")
                {
                    break;
                }

                foreach (char k in input)
                {
                    if (k == 'K')
                    {
                        if (fireFightersLeft == 0)
                        {
                            break;
                        }

                        kidsSaved++;
                        fireFightersLeft--;
                    }
                }

                if (fireFightersLeft > 0)
                {
                    foreach (char a in input)
                    {
                        if (a == 'A')
                        {
                            if (fireFightersLeft == 0)
                            {
                                break;
                            }

                            adultsSaved++;
                            fireFightersLeft--;
                        }
                    }
                }

                if (fireFightersLeft > 0)
                {
                    foreach (char s in input)
                    {
                        if (s == 'S')
                        {
                            if (fireFightersLeft == 0)
                            {
                                break;
                            }

                            seniorsSaved++;
                            fireFightersLeft--;
                        }
                    }
                }

                fireFightersLeft = fireFightersTotal;
            }

            Console.WriteLine("Kids: {0}{3}Adults: {1}{3}Seniors: {2}", 
                kidsSaved, adultsSaved, seniorsSaved, Environment.NewLine);
        }
    }
}