using System;
using System.Globalization;
using System.Threading;

class SumOfNumbers
    {
        static void Main()
        {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum:  {0}+{1}+{2}={3}",number1,number2,number3,number1+number2+number3 );
    }
    }

