namespace Abstraction.Figures
{
    using System;
    using Contracts;

    /// <summary>
    /// The Rectangle Class
    /// </summary>
    /// <seealso cref="Abstraction.Figures.Figure" />
    /// <seealso cref="Abstraction.Contracts.IRectangle" />
    public class Rectangle : Figure, IRectangle
    {
        private double width;
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
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
                    throw new ArgumentOutOfRangeException("width", "Rectangle's width cannot be zero or negative !");
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
                    throw new ArgumentOutOfRangeException("height", "Rectangle's height cannot be zero or negative !");
                }

                this.height = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}