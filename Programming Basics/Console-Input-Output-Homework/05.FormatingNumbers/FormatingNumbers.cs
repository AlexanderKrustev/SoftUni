using System;
using System.Globalization;
using System.Threading;

class Program
    {
        static void Main()
        {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        bool invalid = true;
        int a = 0;
        while (invalid)
        {
            Console.Write("Enter first number (allowed range 0<=a<=500): ");
            a = int.Parse(Console.ReadLine());
            if(a>=0 && a <= 500)
            {
                invalid = false;
            }
        }
        Console.Write("Enter second number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third numebr c: ");
        double c = double.Parse(Console.ReadLine());
        string binary = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.WriteLine("|{0,-10:X}|{1,10}|{2,11:0.0|}{3,-10:0.00}",a,binary,b,c);

    }
    }

