using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.AccountTypes
{
    public class Mortgage : Account, IDepositable
    {
        public Mortgage(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {

        }

        public void DepositMoney(decimal money)
        {
            Balance += money;
        }

        public override decimal CalculateRate(int months)
        {
            if (Customer == Customer.Individual && months <= 6)
            {
                return 0;
            }

            if (Customer == Customer.Company && months <= 12)
            {
                return base.CalculateRate(months) / 2;
            }

            return base.CalculateRate(months);
        }
    }
}