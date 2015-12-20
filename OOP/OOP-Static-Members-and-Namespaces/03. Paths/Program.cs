using _02.CalculaateDistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Paths
{
    class Program
    {
        
         public    static void Main()
        {
                Point3D p1 = new Point3D(45, -5, 23);
                Point3D p2 = new Point3D(-25, 78, 115);
                Point3D p3 = new Point3D(2, 56, -8);

                List<Point3D> points1 = new List<Point3D> { p1, p2, p3 };
                List<Point3D> points2 = new List<Point3D> { p2, p3 };
                List<Point3D> points3 = new List<Point3D> { p1, p3 };

                Path3D path1 = new Path3D(points1);
                Path3D path2 = new Path3D(points2);
                Path3D path3 = new Path3D(points3);
                //Console.WriteLine(path1);

                Storage.SavePath(@"C:\Users\alex\OneDrive\Документи\Visual Studio 2015\Projects\OOP-Static-Members-and-Namespaces\03. Paths\paths.txt", path1, path2, path3);
                Path3D newPath = Storage.LoadPath(@"C:\Users\alex\OneDrive\Документи\Visual Studio 2015\Projects\OOP-Static-Members-and-Namespaces\03. PathspathToLoad.txt");
                Storage.SavePath(@"C: \Users\alex\OneDrive\Документи\Visual Studio 2015\Projects\OOP - Static - Members - and - Namespaces\03.Paths\paths.txt", newPath);

                Console.WriteLine(newPath);
            }
        }
    }

