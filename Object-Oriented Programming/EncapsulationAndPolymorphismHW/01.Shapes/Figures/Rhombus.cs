using System;

namespace Shapes.Figures
{
    public class Rhombus : BasicShape
    {
        public Rhombus(double width) : base(width, width)
        {
            
        }

        public override double CalculateArea()
        {
            double area = Math.Abs(Math.Pow(Width, 2) * Math.Sin(Width));
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 4 * Width;
            return perimeter;
        }

        public override string ToString()
        {
            return string.Format("Figure: {0}{3}Area: {1:F2}{3}Perimeter: {2:F2}{3}{3}",
                GetType().Name, CalculateArea(), CalculatePerimeter(), Environment.NewLine);
        }
    }
}