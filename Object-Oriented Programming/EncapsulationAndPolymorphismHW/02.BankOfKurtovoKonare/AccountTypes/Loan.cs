namespace BankOfKurtovoKonare.AccountTypes
{
    #region

    using BankOfKurtovoKonare.Interfaces;

    #endregion

    public class Loan : Account, IDepositable
    {
        public Loan(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {
        }

        public override decimal CalculateRate(int months)
        {
            if (this.Customer == Customer.Individual && months <= 3)
            {
                return 0;
            }

            if (this.Customer == Customer.Individual && months <= 2)
            {
                return 0;
            }

            return base.CalculateRate(months);
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }
    }
}