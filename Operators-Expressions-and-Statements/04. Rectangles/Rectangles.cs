using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Rectangles
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Width= ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Height= ");
        double heigth = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter= {0} , Area= {1}",(2*width)+(2*heigth),width*heigth);
    }
    }

