namespace Shapes
{
    using System;

    public abstract class BasicShape : IShape
    {
        private double length;

        private double width;

        protected BasicShape(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }

        public double Length
        {
            get
            {
                return this.length;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Length cannot be lower or equal to zero !");
                }

                this.length = value;
            }
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
                    throw new ArgumentOutOfRangeException("value", "Width cannot be lower or equal to zero !");
                }

                this.width = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}