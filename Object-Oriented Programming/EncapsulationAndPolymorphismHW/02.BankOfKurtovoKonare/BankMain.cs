using System;
using BankOfKurtovoKonare.AccountTypes;

namespace BankOfKurtovoKonare
{
    class BankMain
    {
        static void Main()
        {
            Deposit deposit = new Deposit(400m, 0.01m, Customer.Individual);
            Console.WriteLine("Deposit Account: ");
            Console.WriteLine("Interest rate: " + deposit.CalculateRate(20));

            deposit.DepositMoney(100000m);
            Console.WriteLine("Balance after depositing: " + deposit.Balance);
            Console.WriteLine("Interest rate: " + deposit.CalculateRate(20));

            deposit.WithdrawMoney(100400m);
            Console.WriteLine("Balance after withdrawing: " + deposit.Balance);
            Console.WriteLine();

            Mortgage mortgage = new Mortgage(500000m, 0.02m, Customer.Company);
            Console.WriteLine("Mortgage Account: ");
            Console.WriteLine("Interest rate for company: " + mortgage.CalculateRate(12));
            mortgage.Customer = Customer.Individual;
            Console.WriteLine("Interest rate for individual: " + mortgage.CalculateRate(7));
            Console.WriteLine();

            Loan loan = new Loan(500000m, 0.02m, Customer.Company);
            Console.WriteLine("Loan Account: ");
            Console.WriteLine("Interest rate for company: " + loan.CalculateRate(24));
            loan.Customer = Customer.Individual;
            Console.WriteLine("Interest rate for individual: " + loan.CalculateRate(3));
        }
    }
}
