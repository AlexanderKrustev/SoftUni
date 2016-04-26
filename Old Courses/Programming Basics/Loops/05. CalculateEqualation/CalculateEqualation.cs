using System;

    class CalculateEqualation
    {
        static void Main()
        {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x= ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        int factorial = 1;
        for (int i = 1; i <=n; i++)
        {
            factorial = factorial * i;
            sum = sum +(factorial) / (Math.Pow(x, i));
        }
        Console.WriteLine("S= {0:f5}",sum);    
    }
    }

