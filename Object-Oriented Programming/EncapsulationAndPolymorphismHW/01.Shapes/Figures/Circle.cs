namespace Shapes.Figures
{
    using System;

    public class Circle : IShape
    {
        private double radius;

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
                    throw new ArgumentOutOfRangeException("value", "Radius cannot be ");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(this.radius, 2);
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.radius;
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