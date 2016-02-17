using System;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.AccountTypes
{
    public class Deposit : Account, IWithdrawable, IDepositable
    {
        public Deposit(decimal balance, decimal interestRate, Customer customer)
           : base(balance, interestRate, customer)
        {

        }

        public void DepositMoney(decimal money)
        {
            Balance += money;
        }

        public void WithdrawMoney(decimal money)
        {
            if (Balance < money)
            {
                throw new ArgumentException("There is not enought money in your balance");
            }
            Balance -= money;
        }

        public override decimal CalculateRate(int months)
        {
            if (Balance > 0 && Balance < 1000)
            {
                return 0m;
            }
            return base.CalculateRate(months);
        }
    }
}