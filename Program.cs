using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3d vector1 = new Vector3d(12, 2, 7);
            Vector3d vector2 = new Vector3d(-2, -2, 7);

            Vector3d result = vector1.add(vector2);

            Console.WriteLine("X = {0}", result.X);
            Console.WriteLine("Y = {0}", result.Y);
            Console.WriteLine("Z = {0}", result.Z);
            
            Console.ReadKey();
        }
    }
}
