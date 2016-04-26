using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class Trapezoids
    {
        static void Main(string[] args)
        {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h=");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Area={0}",h*((a+ b)/2));
    }
    }

