using System;

namespace Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double length;

        protected BasicShape(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Width cannot be lower or equal to zero !");
                }
                width = value;
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Length cannot be lower or equal to zero !");
                }
                length = value;
            }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}