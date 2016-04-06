namespace Shapes
{
    using System;
    using System.Collections.Generic;

    using Figures;

    public class ShapesMain
    {
        public static void Main()
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Rhombus rhobus = new Rhombus(5);
            Circle circle = new Circle(5);

            List<IShape> shapes = new List<IShape> { circle, rhobus, rectangle };

            foreach (var figure in shapes)
            {
                Console.WriteLine(figure);
            }
        }
    }
}