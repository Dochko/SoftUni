using CohesionAndCoupling.Utilities.FileUtilities;
using CohesionAndCoupling.Utilities.GeometryUtilities;

namespace CohesionAndCoupling
{
    using System;
    using Contracts;
    using Models;
    using static FileUtilities;
    using static GeometrynUtilities;

    /// <summary>
    /// A demo of the CohesionAndCoupling utilities.
    /// </summary>
    public class UtilsExamples
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(GetFileExtension("example"));
            Console.WriteLine(GetFileExtension("example.pdf"));
            Console.WriteLine(GetFileExtension("example.new.pdf"));

            Console.WriteLine(GetFileNameWithoutExtension("example"));
            Console.WriteLine(GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", CalcDistance3D(5, 2, -1, 3, -6, 4));

            IShape figure = new Shape(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", figure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", CalcDistance3D(0, 0, 0, figure.Width, figure.Height, figure.Depth));
            Console.WriteLine("Diagonal XY = {0:f2}", CalcDistance2D(0, 0, figure.Width, figure.Height));
            Console.WriteLine("Diagonal XZ = {0:f2}", CalcDistance2D(0, 0, figure.Width, figure.Depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", CalcDistance2D(0, 0, figure.Height, figure.Depth));
        }
    }
}
