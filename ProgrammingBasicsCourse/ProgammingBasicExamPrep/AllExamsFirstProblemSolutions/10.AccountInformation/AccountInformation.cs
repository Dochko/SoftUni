using System;

class AccountInformation
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        long clientId = long.Parse(Console.ReadLine());
        double accountBalance = double.Parse(Console.ReadLine());

        Console.WriteLine("Hello, {0} {1}", firstName, lastName);
        Console.WriteLine("Client id: {0}" , clientId);
        Console.WriteLine("Total balance: {0:F2}", accountBalance);
        if (accountBalance < 0)
        {
            Console.WriteLine("Active: no");
        }
        else
        {
            Console.WriteLine("Active: yes");
        }
    }
}