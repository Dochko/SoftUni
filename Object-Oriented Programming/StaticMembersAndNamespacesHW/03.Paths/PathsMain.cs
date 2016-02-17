using System;
using System.Collections.Generic;

namespace Paths
{
    class PathsMain
    {
        static void Main()
        {
            List<Path3D> sequenceOfPoints = new List<Path3D>();

            Path3D pointOne = new Path3D(1.123f, 2.234f, 3.456f);
            Path3D pointTwo = new Path3D(5.678f, 6.789f, 7.890f);
            Path3D pointThree = new Path3D(0.1264f, 13.665f, 19.789f);

            sequenceOfPoints.Add(pointOne);
            sequenceOfPoints.Add(pointTwo);
            sequenceOfPoints.Add(pointThree);

            //You can delete the text file in the Debug folder and comment
            //the LoadPoints() method to check, that the program works :)
            Storage.SavePoints(sequenceOfPoints);

            Storage.LoadPoints();
        }
    }
}
