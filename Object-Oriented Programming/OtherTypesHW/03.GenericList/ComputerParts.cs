using System;

namespace GenericList
{
    public class ComputerParts : IComparable<ComputerParts>
    {
        private string name;
        private decimal price;

        public ComputerParts(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("part name", "Name cannot be null or empty !");
                }
                name = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("part price", "Price cannot be negative !");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}lv.", Name, Price);
        }

        public int CompareTo(ComputerParts other)
        {
            return Price.CompareTo(other.Price);
        }
    }
}