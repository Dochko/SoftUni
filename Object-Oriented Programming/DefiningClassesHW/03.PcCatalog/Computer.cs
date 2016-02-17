using System;
using System.Collections.Generic;

namespace PcCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components;
        private decimal price;

        public Computer(string name, List<Component> components)
        {
            Name = name;
            Components = components;
        }

        public string Name
        {
            get { return name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Computer name is mandatory !");
                }
                name = value;
            }
        }

        public List<Component> Components
        {
            get { return components; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Components are mandatory !");
                }
                components = value;
            }
        }

        private decimal Price()
        {
            foreach (var component in components)
            {
                price += component.Price;
            }

            return price;
        }

        public override string ToString()
        {
            string output = "Computer name: " + name + "\n";

            foreach (var component in components)
            {
                output += component;
            }

            decimal price = Price();
            output += "Components price: " + price + " lv.\n";
            return output;
        }
    }
}