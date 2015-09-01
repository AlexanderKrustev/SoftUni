using System;



    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            Console.WriteLine("A={0} {1}B={2}", a, Environment.NewLine, b);
            a = a + b;
            b = a - b;
            a = a - b;
           Console.WriteLine("A={0} {1}B={2}", a, Environment.NewLine, b);
        }
    }

