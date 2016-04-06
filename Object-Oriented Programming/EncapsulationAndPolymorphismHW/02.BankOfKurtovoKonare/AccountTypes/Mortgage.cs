namespace BankOfKurtovoKonare.AccountTypes
{
    #region

    using BankOfKurtovoKonare.Interfaces;

    #endregion

    public class Mortgage : Account, IDepositable
    {
        public Mortgage(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {
        }

        public override decimal CalculateRate(int months)
        {
            if (this.Customer == Customer.Individual && months <= 6)
            {
                return 0;
            }

            if (this.Customer == Customer.Company && months <= 12)
            {
                return base.CalculateRate(months) / 2;
            }

            return base.CalculateRate(months);
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }
    }
}