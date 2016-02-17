using System;
using System.Linq;

class BabaTincheAirlines
{
    static void Main()
    {
        string[] firstClass = Console.ReadLine().Split();
        string[] secondClass = Console.ReadLine().Split();
        string[] thirdClass = Console.ReadLine().Split();
        
        int firstClassProfit = (Convert.ToInt32(firstClass[0]) - Convert.ToInt32(firstClass[1])) * 7000;
        firstClassProfit += (int)(Convert.ToInt32(firstClass[1]) * (7000 * 0.3));
        firstClassProfit += (int)(Convert.ToInt32(firstClass[2]) * (0.005 * 7000));

        int secondClassProfit = (Convert.ToInt32(secondClass[0]) - Convert.ToInt32(secondClass[1])) * 3500;
        secondClassProfit += (int)(Convert.ToInt32(secondClass[1]) * (3500 * 0.3));
        secondClassProfit += (int)(Convert.ToInt32(secondClass[2]) * (0.005 * 3500));

        int thirdClassProfit = (Convert.ToInt32(thirdClass[0]) - Convert.ToInt32(thirdClass[1])) * 1000;
        thirdClassProfit += (int)(Convert.ToInt32(thirdClass[1]) *  (1000 * 0.3));
        thirdClassProfit += (int)(Convert.ToInt32(thirdClass[2]) * (0.005 * 1000));

        int sumProfit = firstClassProfit + secondClassProfit + thirdClassProfit;

        int maxProfit = (int)(12 * 7000 + 12 * (0.005 * 7000)) + (int)(28 * 3500 + 28 * (0.005 * 3500)) + (int)(50 * 1000 + 50 *(0.005 * 1000));

        Console.WriteLine(sumProfit);
        Console.WriteLine(maxProfit - sumProfit);
    }
}