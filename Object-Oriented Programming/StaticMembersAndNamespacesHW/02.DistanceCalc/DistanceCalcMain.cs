using System;

namespace _02.DistanceCalc
{
    class DistanceCalcMain
    {
        static void Main()
        {
            Point3D first3DPoint = new Point3D(1.3919023f, 6.12837912f, 10.391283f);
            Point3D second3DPoint = new Point3D(48.3818f, 38.38182f, 318.381823f);

            Console.WriteLine(first3DPoint.ToString());
            Console.WriteLine(second3DPoint.ToString());

            DistanceCalculator.DistanceCalculation(first3DPoint, second3DPoint);

        }
    }
}
