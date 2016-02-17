using System;

namespace InterestCalculator
{
    public delegate decimal CalculateInterest(decimal money, double interest, int years);

    public class InterestCalculator
    {
        private decimal money;
        private double interest;
        private int years;
        private readonly CalculateInterest calculationMethod;

        public InterestCalculator(decimal money, double interest, int years, CalculateInterest calculationMethod)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.calculationMethod = calculationMethod;
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("money", "Money cannot be negative !");
                }
               this.money = value;
            }
        }

        public double Interest
        {
            get { return this.interest; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("interest", "Interest rate cannot be negative !");
                }
                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("years", "The number of years cannot be negative.");
                }

                this.years = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.calculationMethod(this.Money, this.Interest, this.Years); 
                
            }
        }
    }
}