using System;

    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please enter five numbers in one row separated with space");
        string s = Console.ReadLine();
        string[] stringNumbers = s.Split(' ');
        double number1 = double.Parse(stringNumbers[0]);
        double number2 = double.Parse(stringNumbers[1]);
        double number3 = double.Parse(stringNumbers[2]);
        double number4 = double.Parse(stringNumbers[3]);
        double number5 = double.Parse(stringNumbers[4]);
        double sum = number1 + number2 + number3 + number4 + number5;
        Console.WriteLine(sum);
    }
    }

