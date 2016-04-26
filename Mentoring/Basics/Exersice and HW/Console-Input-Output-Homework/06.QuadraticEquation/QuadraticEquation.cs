using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
    {
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter parameters of an quadratic equation ax^2 + bx + c = 0 ");
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());
        double D = Math.Pow(b, 2) - (4 * a * c) ;
        if (D > 0)
        {
         Console.Write("x1={0}; ",(-b - Math.Sqrt(D))/(2* a));
         Console.WriteLine("x2={0}", (-b + Math.Sqrt(D)) / (2 * a));
        }
        else if(D == 0)
        {
            Console.WriteLine("x1=x2={0}; ", (-b + Math.Sqrt(D)) / (2 * a));
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }

    }

