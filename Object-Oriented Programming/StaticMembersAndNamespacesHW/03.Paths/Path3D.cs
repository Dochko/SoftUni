using System.Collections.Generic;

namespace Paths
{
    public class Path3D
    {
        private float x;
        private float y;
        private float z;
        
        public Path3D(float x, float y, float z)
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

        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}, Z: {2}", x, y, z);
        }
    }
}