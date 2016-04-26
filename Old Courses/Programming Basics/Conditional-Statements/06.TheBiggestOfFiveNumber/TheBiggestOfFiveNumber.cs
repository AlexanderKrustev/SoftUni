using System;

    class TheBiggestOfFiveNumber
    {
        static void Main()
        {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d= ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());
        double max = a;
        if (max < b)
        {
            max = b;
        }
        if (max< c)
        {
            max = c;
        }
        if (max < d)
        {
            max = d;
        }
        if (max < e)
        {
            max = e;
        }
        Console.WriteLine("Biggest is {0}",max);

    }
    }

