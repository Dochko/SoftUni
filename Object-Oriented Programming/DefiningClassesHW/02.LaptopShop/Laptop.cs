using System;

namespace LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            Model = model;
            Price = price;
        }

        public Laptop(string model, string manufacturer, string processor, int ram,
            string graphicsCard, string hdd, string screen, Battery battery, decimal price) : this(model, price)
        {
            Manufacturer = manufacturer;
            Processor = processor;
            Ram = ram;
            GraphicsCard = graphicsCard;
            Hdd = hdd;
            Screen = screen;
            Battery = battery;
        }

        public string Model
        {
            get { return model; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model is mandatory !");
                }
                model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }

            set
            {
                manufacturer = value;
            }
        }

        public string Processor
        {
            get { return processor; }

            set
            {
                processor = value;
            }

        }

        public int Ram
        {
            get { return ram; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("RAM memory cannot be lower than 0 !");
                }
                ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return graphicsCard; }

            set
            {
                graphicsCard = value;
            }
        }

        public string Hdd
        {
            get { return hdd; }

            set
            {
                hdd = value;
            }
        }

        public string Screen
        {
            get { return screen; }

            set
            {
                screen = value;
            }
        }

        public Battery Battery
        {
            get { return battery; }

            set
            {
                battery = value;
            }
        }


        public decimal Price
        {
            get { return price; }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Price is mandatory and cannot be lower than 0 !");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            string output = "Model: " + model + "\n";

            if (manufacturer == null)
            {
                output += "Price: " + price + " lv.\n";
            }
            else
            {
                output += "Manufacturer: " + manufacturer + "\n";
                output += "Processor: " + processor + "\n";
                output += "RAM: " + ram + "GB\n";
                output += "Graphics Card: " + graphicsCard + "\n";
                output += "HDD: " + hdd + "\n";
                output += "Screen: " + screen + "\n";
                output += battery;
                output += "Price: " + price + "\n";
            }

            return output;
        }
    }
}