namespace Abstraction
{
    using System;
    using Contracts;
    using Figures;

    /// <summary>
    /// A demo for the Figure, Circle and Rectangle classes.
    /// </summary>
    public class FiguresExample
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            IFigure circle = new Circle(5);
            Console.WriteLine(circle.ToString());

            IFigure rectangle = new Rectangle(2, 3);
            Console.WriteLine(rectangle.ToString());
        }
    }
}