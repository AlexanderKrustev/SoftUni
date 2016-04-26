using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class Program
    {
        static void Main()
        {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("n= ");
        int n = int.Parse(Console.ReadLine());
        List<double> numbers = new List<double>();
        double sum = 0;
        for(int x=0; x < n; x++)
        {
        
           numbers.Add(double.Parse(Console.ReadLine()));
        }
        foreach( double x in numbers)
        {
            sum += x;
        }
        Console.WriteLine("Sum= {0}",sum);
        }
    }

