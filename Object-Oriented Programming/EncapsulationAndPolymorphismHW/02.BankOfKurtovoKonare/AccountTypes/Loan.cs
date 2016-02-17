using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.AccountTypes
{
    public class Loan : Account,IDepositable
    {
        public Loan(decimal balance, decimal interestRate, Customer customer)
           : base(balance, interestRate, customer)
        {

        }

        public void DepositMoney(decimal money)
        {
            Balance += money;
        }

        public override decimal CalculateRate(int months)
        {
            if (Customer == Customer.Individual && months <= 3)
            {
                return 0;
            }

            else if (Customer == Customer.Individual && months <= 2)
            {
                return 0;
            }

            return base.CalculateRate(months);
        }
    }
}