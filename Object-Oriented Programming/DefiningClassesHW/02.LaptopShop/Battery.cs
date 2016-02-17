using System;

namespace LaptopShop
{
    public class Battery
    {
        private string batteryType;
        private double batteryLife;

        public Battery(string batteryType, double batteryLife)
        {
            BatteryType = batteryType;
            BatteryLife = batteryLife;
        }

        public string BatteryType
        {
            get { return batteryType; }

            set
            {
                batteryType = value;
            }
        }

        public double BatteryLife
        {
            get { return batteryLife; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours cannot be lower than 0 !");
                }
                batteryLife = value;
            }
        }

        public override string ToString()
        {
            string battery = "battery: " + batteryType + "\n";
            battery += "battery life: " + batteryLife + " hours\n";
            return battery;
        }
    }
}