using System;

namespace GalacticGPS
{
    class GalacticGPSMain
    {
        static void Main()
        {
            Location home = new Location(18.037987, 28.870097, Planet.Earth);
            Console.WriteLine(home);

            Location mars = new Location(25.245212, 45.343454, Planet.Mars);
            Console.WriteLine(mars);
        }
    }
}
