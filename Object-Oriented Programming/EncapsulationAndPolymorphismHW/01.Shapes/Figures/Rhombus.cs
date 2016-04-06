namespace Shapes.Figures
{
    using System;

    public class Rhombus : BasicShape
    {
        public Rhombus(double width)
            : base(width, width)
        {
        }

        public override double CalculateArea()
        {
            double area = Math.Abs(Math.Pow(this.Width, 2) * Math.Sin(this.Width));
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 4 * this.Width;
            return perimeter;
        }

        public override string ToString()
        {
            return string.Format(
                "Figure: {0}{3}Area: {1:F2}{3}Perimeter: {2:F2}{3}{3}", 
                this.GetType().Name, 
                this.CalculateArea(), 
                this.CalculatePerimeter(), 
                Environment.NewLine);
        }
    }
}