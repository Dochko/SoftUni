namespace BankOfKurtovoKonare.AccountTypes
{
    #region

    using System;

    using BankOfKurtovoKonare.Interfaces;

    #endregion

    public class Deposit : Account, IWithdrawable, IDepositable
    {
        public Deposit(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {
        }

        public override decimal CalculateRate(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0m;
            }

            return base.CalculateRate(months);
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public void WithdrawMoney(decimal money)
        {
            if (this.Balance < money)
            {
                throw new ArgumentException("There is not enought money in your balance");
            }

            this.Balance -= money;
        }
    }
}