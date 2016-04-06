namespace Shapes.Figures
{
    using System;

    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double length)
            : base(width, length)
        {
        }

        public override double CalculateArea()
        {
            var area = this.Width * this.Length;
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = (this.Width + this.Length) * 2;
            return perimeter;
        }

        public override string ToString()
        {
            return string.Format(
                "Figure: {0}{3}Area: {1:F2}{3}Perimeter: {2:F2}{3}", 
                this.GetType().Name, 
                this.CalculateArea(), 
                this.CalculatePerimeter(), 
                Environment.NewLine);
        }
    }
}