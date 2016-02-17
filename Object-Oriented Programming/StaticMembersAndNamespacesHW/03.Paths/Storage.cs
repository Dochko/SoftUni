using System;
using System.Collections.Generic;
using System.IO;

namespace Paths
{
    public static class Storage
    {
        public static void SavePoints(List<Path3D> points)
        {
            TextWriter savePoints = new StreamWriter("SavedPoints.txt");

            foreach (var point in points)
            {
                savePoints.WriteLine(point);
            }
            
            savePoints.Close();
        }

        public static void LoadPoints()
        {
            TextReader loadPoints = new StreamReader("SavedPoints.txt");

            string point = loadPoints.ReadToEnd();

            Console.WriteLine(point);

            loadPoints.Close();
        }
    }
}