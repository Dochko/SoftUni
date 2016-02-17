namespace Abstraction.Figures
{
    using System;
    using Contracts;

    /// <summary>
    /// The Circle Class.
    /// </summary>
    /// <seealso cref="Abstraction.Figures.Figure" />
    /// <seealso cref="Abstraction.Contracts.ICircle" />
    public class Circle : Figure, ICircle
    {
        private double radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius.</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius; 
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("radius", "Radius cannot be negative or zero !");
                }

                this.radius = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}