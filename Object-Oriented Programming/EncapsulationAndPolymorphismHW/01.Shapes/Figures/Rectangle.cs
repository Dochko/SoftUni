using System;

namespace Shapes.Figures
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double length) : base(width, length)
        {
            
        }

        public override double CalculateArea()
        {
            double area = Width * Length;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = (Width + Length)  *2;
            return perimeter;
        }

        public override string ToString()
        {
            return string.Format("Figure: {0}{3}Area: {1:F2}{3}Perimeter: {2:F2}{3}",
                GetType().Name, CalculateArea(), CalculatePerimeter(), Environment.NewLine);
        }
    }
}