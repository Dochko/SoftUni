using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Persons
{
    public class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(int id, string firstName, string lastName, decimal netPurchaseAmount) : base(id, firstName, lastName)
        {
            NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return netPurchaseAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Purchase amount cannot be negative !");
                }
                netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            string str = string.Format(base.ToString() + "Money spent on purchases: {0}", netPurchaseAmount);
            return str;
        }
    }
}