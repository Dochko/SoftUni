using System;

class TorrentPirate
{
    static void Main()
    {
        double downloadData = double.Parse(Console.ReadLine());
        double cinemaCost = double.Parse(Console.ReadLine());
        double wifeSpending = double.Parse(Console.ReadLine());

        double priceForDownload = (downloadData / 2 / 60 / 60) * wifeSpending;
        double cinemaPrice = (downloadData / 1500) * cinemaCost;

        if (priceForDownload > cinemaPrice)
        {
            Console.WriteLine("cinema -> {0:F}lv", cinemaPrice);
        }
        else
        {
            Console.WriteLine("mall -> {0:F}lv" , priceForDownload);
        }
    }
}