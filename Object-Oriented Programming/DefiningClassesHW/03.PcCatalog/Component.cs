using System;

namespace PcCatalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, string details, decimal price)
        {
            Name = name;
            Details = details;
            Price = price;
        }

        public string Name
        {
            get { return name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name is mandatory !");
                }
                name = value;
            }
        }

        public string Details
        {
            get { return details; }

            set { details = value; }
        }

        public decimal Price
        {
            get { return price; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price is mandatory and cannot be lower than 0 !");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            string output = "Component name: " + name + "\n";

            if (!string.IsNullOrWhiteSpace(details))
            {
                output += "Component details: " + details + "\n";
            }
            else
            {
                output += "Component details: no details.\n";
            }

            output += "Component price: " + price + " lv.\n";
            return output;
        }
    }
}