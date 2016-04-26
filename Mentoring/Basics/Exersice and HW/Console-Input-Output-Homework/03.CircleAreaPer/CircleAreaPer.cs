using System;
using System.Globalization;
using System.Threading;

class CircleAreaPer
    {
        static void Main()
        {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter the radius of the circle r");
        double radius= double.Parse(Console.ReadLine());
        Console.WriteLine("The radius={0}, Area={1:F2} , Perimeter={2:F2}",radius,2*Math.PI*radius,Math.PI*Math.Pow(radius,2));
        }
    }

