using System;

class TheBetterMusicProducer
{
    static void Main()
    {
        int europeAlbumsSold = int.Parse(Console.ReadLine());
        double euroPriceOfAlbums = double.Parse(Console.ReadLine());
        int northMuricaAlbumsSold = int.Parse(Console.ReadLine());
        double dollarsPriceOfAlbums = double.Parse(Console.ReadLine());
        int southMuricaAlbumsSold = int.Parse(Console.ReadLine());
        double pesosPriceOfAlbums = double.Parse(Console.ReadLine());

        int tourConcerts = int.Parse(Console.ReadLine());
        double euroConcertProfit = double.Parse(Console.ReadLine());

        double sumOfAllAlbums = ((europeAlbumsSold * euroPriceOfAlbums) * 1.94) + ((northMuricaAlbumsSold * dollarsPriceOfAlbums) * 1.72) + ((southMuricaAlbumsSold * pesosPriceOfAlbums) / 332.74);
        double profitLeftFromProducer = sumOfAllAlbums - (sumOfAllAlbums * 0.35);
        double profitFromAllAlbums = profitLeftFromProducer - (profitLeftFromProducer * 0.2);

        double concertProfit = (tourConcerts * euroConcertProfit) * 1.94;

        double profitFromConcerts = 0;

        if (concertProfit > 100000)
        {
            profitFromConcerts = concertProfit - (concertProfit * 0.15);
        }
        else
        {
            profitFromConcerts = concertProfit;
        }

        if (profitFromConcerts < profitFromAllAlbums)
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", profitFromAllAlbums);
        }
        else if (profitFromConcerts >= profitFromAllAlbums)
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", profitFromConcerts);
        }
    }
}