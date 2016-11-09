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
            Vector3d vector1 = new Vector3d(1.2f, 2.5f, 7f);
            Vector3d vector2 = new Vector3d(-2f, -2.5f, 7f);

            Vector3d result = vector1.add(vector2);

            Console.WriteLine("Vector1 length: {0}", vector1.getLength());
            Console.WriteLine("Vector1 length: {0}", vector2.getLength());

            Console.WriteLine("Vector 1 and 2 added:");
            Console.WriteLine("X = {0}", result.X);
            Console.WriteLine("Y = {0}", result.Y);
            Console.WriteLine("Z = {0}", result.Z);
            
            Console.ReadKey();
        }
    }
}
