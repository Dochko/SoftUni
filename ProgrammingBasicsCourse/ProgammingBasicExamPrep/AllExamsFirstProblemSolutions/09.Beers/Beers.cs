using System;

class Beers
{
    static void Main()
    {
        int quantity;
        int beerCounter = 0;
        for (int i = 1; i < 999; i++)
        {
            string inputData = Console.ReadLine();

            if (inputData == "End")
            {
                break;
            }

            string[] data = inputData.Split(' ');

            quantity = int.Parse(data[0]);

            if (quantity > 99 || quantity < 1)
            {
                Console.WriteLine("Invalid quantity");
            }


            if (data[1] == "stacks")
            {
                beerCounter += quantity*20;
            }
            else if (data[1] == "beers")
            {
                beerCounter += quantity;
            }
        }

        int stacks = beerCounter / 20;
        int beers = beerCounter % 20;

        Console.WriteLine("{0} stacks + {1} beers", stacks , beers);
    }
}