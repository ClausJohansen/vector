using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector3d
    {
        private int x, y, z;

        public Vector3d(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int Z { get { return z; } }

        public double getLength()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }

        public Vector3d add(Vector3d addition)
        {
            int resultX = x + addition.x;
            int resultY = y + addition.y;
            int resultZ = z + addition.z;

            return new Vector3d(resultX, resultY, resultZ);
        }
    }
}
