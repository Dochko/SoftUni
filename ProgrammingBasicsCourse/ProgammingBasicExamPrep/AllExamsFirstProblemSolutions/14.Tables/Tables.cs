using System;

class Tables
{
    static void Main()
    {
        int bundleOne = int.Parse(Console.ReadLine());
        int bundleTwo = int.Parse(Console.ReadLine());
        int bundleThree = int.Parse(Console.ReadLine());
        int bundleFour = int.Parse(Console.ReadLine());
        int tableTops = int.Parse(Console.ReadLine());
        int tablesToBeMade = int.Parse(Console.ReadLine());

        int legs = (bundleOne * 1) + (bundleTwo * 2) + (bundleThree * 3) + (bundleFour * 4);
        int legsReq = tablesToBeMade * 4;

        if (tablesToBeMade < tableTops && legsReq < legs)
        {
            if (tablesToBeMade == tableTops && legsReq == legs)
            {
                Console.WriteLine("Just enough tables made: {0}", tablesToBeMade);
            }

            else
            {
                Console.WriteLine("more: {0}", tableTops - tablesToBeMade);
                Console.WriteLine("tops left: {0}, legs left: {1}", tableTops - tablesToBeMade, legs - legsReq);
            }
        }

        else if (tablesToBeMade > tableTops || legsReq <= legs)
        {
            Console.WriteLine("less: {0}", tableTops - tablesToBeMade);
            Console.WriteLine("tops needed: {0}, legs needed: 0", tablesToBeMade - tableTops, legs - legsReq);
        }

        else if (tablesToBeMade <= tableTops || legsReq > legs)
        {
            Console.WriteLine("less: {0}", legs - legsReq);
            Console.WriteLine("tops needed: 0, legs needed: {0}", legs - legsReq);
        }
    }
}