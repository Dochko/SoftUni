using System;

namespace BankOfKurtovoKonare
{
    public class Account
    {
        private decimal interestRate;

        protected Account(decimal balance, decimal interestRate, Customer customer)
        {
            Balance = balance;
            InterestRate = interestRate;
            Customer = customer;
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be neggative");
                }
                interestRate = value;
            }
        }

        public decimal Balance { get; set; }

        public Customer Customer { get; set; }

        public virtual decimal CalculateRate(int months)
        {
            decimal money = Balance;
            decimal rate = money * (1 + interestRate * months);

            return rate;
        }
    }
}