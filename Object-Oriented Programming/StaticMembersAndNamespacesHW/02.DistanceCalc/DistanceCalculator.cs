using System;

namespace _02.DistanceCalc
{
    public class DistanceCalculator
    {
        public static float DistanceCalculation(Point3D first3dPoint, Point3D second3dPoint)
        {
            float deltaX = second3dPoint.X - first3dPoint.X;
            float deltaY = second3dPoint.Y - second3dPoint.Y;
            float deltaZ = second3dPoint.Z - second3dPoint.Z;

            float distance = (float) Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);

            Console.WriteLine("Distance between first point and second point is: " + distance);
            return distance;
        }
    }
}