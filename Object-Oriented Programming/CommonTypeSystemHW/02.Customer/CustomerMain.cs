using System;
using System.Linq;

namespace Customer
{
    public class CustomerMain
    {
        static void Main()
        {
            Payment videoCard = new Payment("Nvidia GTX 670", 250m);
            Payment ssd = new Payment("SSD", 150.32m);
            Customer pesho = new Customer("Pesho", "Ivanov", 8712013812, CustomerType.OneTime, videoCard, ssd);

            Payment vacation = new Payment("Vacation", 1250);
            Customer mariika = new Customer("Mariika", "Petrova", "Ilieva", 3203631101, CustomerType.Diamond, "Plovdiv", null, null, vacation);

            Customer mariikaCopy = (Customer)mariika.Clone();

            Customer goshko = new Customer("Goshko", "Petrov", 9912121212, CustomerType.Golden, ssd, vacation, videoCard);

            Console.WriteLine(pesho == mariika);
            Console.WriteLine(mariika == mariikaCopy);
            Console.WriteLine();

            Customer[] customers = { pesho, mariika, goshko };
            Array.Sort(customers);
            Console.WriteLine(string.Join("\n", customers.ToList()));
        }
    }
}
