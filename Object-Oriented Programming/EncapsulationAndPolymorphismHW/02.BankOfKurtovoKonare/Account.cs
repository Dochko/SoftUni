namespace BankOfKurtovoKonare
{
    #region

    using System;

    #endregion

    public class Account
    {
        private decimal interestRate;

        protected Account(decimal balance, decimal interestRate, Customer customer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Customer = customer;
        }

        public decimal Balance { get; set; }

        public Customer Customer { get; set; }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative");
                }

                this.interestRate = value;
            }
        }

        public virtual decimal CalculateRate(int months)
        {
            var money = this.Balance;
            var rate = money * (1 + this.interestRate * months);

            return rate;
        }
    }
}