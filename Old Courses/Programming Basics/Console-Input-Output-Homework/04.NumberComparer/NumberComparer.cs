using System;
using System.Globalization;
using System.Threading;

class NumberComparer

    {
        static void Main()
        {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter first digit:");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second digit:");
        double number2 = double.Parse(Console.ReadLine());
        double max = 0;
        max= (number1 + number2) / 2.0 + Math.Abs((number1 - number2) / 2);
        Console.WriteLine("From {0} and {1} the bigger one is {2}",number1,number2,max);
    }
    }

