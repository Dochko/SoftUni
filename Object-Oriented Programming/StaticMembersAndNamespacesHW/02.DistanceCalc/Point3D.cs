namespace _02.DistanceCalc
{
    public class Point3D
    {
        private float x;
        private float y;
        private float z;
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public Point3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public float Z
        {
            get { return z; }
            set { z = value; }
        }

        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }



        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}, Z: {2}", x, y, z);
        }
    }
}