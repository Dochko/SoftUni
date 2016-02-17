using System;

namespace Shapes.Figures
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Radius cannot be ");
                }
                radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }

        public override string ToString()
        {
            return string.Format("Figure: {0}{3}Area: {1:F2}{3}Perimeter: {2:F2}{3}{3}",
                GetType().Name, CalculateArea(), CalculatePerimeter(), Environment.NewLine);
        }
    }
}