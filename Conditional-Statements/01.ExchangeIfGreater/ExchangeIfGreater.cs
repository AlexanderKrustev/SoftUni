using System;



    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                double c = a;
                a = b;
                b = c;
                Console.WriteLine("a = {0} , b = {1}",a,b);
            }
            else
            {
                Console.WriteLine("a = {0} , b = {1}", a, b);
            }
        }
    }

