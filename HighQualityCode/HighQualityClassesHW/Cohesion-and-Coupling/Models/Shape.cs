namespace CohesionAndCoupling.Models
{
    using System;
    using Contracts;

    /// <summary>
    /// The Shape Class, which describes a box.
    /// </summary>
    /// <seealso cref="CohesionAndCoupling.Contracts.IShape" />
    public class Shape : IShape
    {
        private double width;
        private double height;
        private double depth;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="depth">The depth.</param>
        public Shape(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width; 
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("width", "Width cannot be zero or negative !");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("height", "Height cannot be zero or negative !");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("depth", "Depth cannot be zero or negative !");
                }

                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }
    }
}