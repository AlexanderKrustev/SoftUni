using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CalculaateDistance
{
    class Test
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(2, 2, 2);
            Point3D point2 = new Point3D(3, 3, 3);
            Console.WriteLine("Distance betweet point with coordinates {0} and point with coordinates {1} is:\n{2}",point1.ToString(),point2.ToString(),Point3D.CalcDistance(point1, point2));
        }
    }
}
