using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector3d
    {
        private float x, y, z;

        public Vector3d(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float X { get { return x; } }
        public float Y { get { return y; } }
        public float Z { get { return z; } }

        public double getLength()
        {
            return (float) Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }

        public Vector3d add(Vector3d addition)
        {
            float resultX = x + addition.x;
            float resultY = y + addition.y;
            float resultZ = z + addition.z;

            return new Vector3d(resultX, resultY, resultZ);
        }
    }
}
