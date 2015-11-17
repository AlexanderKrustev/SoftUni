using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PointInACircle
    {
        static void Main(string[] args)
        {
        Console.Write("x=");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y=");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine((x * x) + (y * y) <= (2 * 2));
    }
    }

