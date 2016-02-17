using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Products
{
    public class Sales : ISales
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sales(string productName, DateTime date, decimal price)
        {
            ProductName = productName;
            Date = date;
            Price = price;
        }

        public string ProductName
        {
            get { return productName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Product name cannot be null !");
                }
                productName = value;
            }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            string str = string.Format("Product name: {0}{5}Date sold: {1}.{2}.{3}{5}Price: {4}{5}", 
                productName, date.Day,date.Month, date.Year, price, Environment.NewLine);
            return str;
        }
    }
}