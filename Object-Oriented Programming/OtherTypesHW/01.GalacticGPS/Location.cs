using System;

namespace GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            Latitude = latitude;
            Longitude = longitude;
            Planet = planet;
        }

        public double Latitude
        {
            get { return latitude; }
            private set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("latitude", 
                        "Latitude must be between -90 and 90 degrees inclusive.");
                }
                latitude = value;
            }
        }

        public double Longitude
        {
            get { return longitude; }
            private set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("longitude",
                        "Longitude must be between -180 and 180 degrees inclusive.");
                }
                longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}",
                Latitude, Longitude, Planet);
        }
    }
}