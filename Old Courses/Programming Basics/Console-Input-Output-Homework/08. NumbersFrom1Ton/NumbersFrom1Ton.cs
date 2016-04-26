using System;
  class NumbersFrom1Ton
    {
        static void Main(string[] args)
        {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        for(int x=1; x<=n; x++)
        {
            Console.WriteLine(x);
        }
        }
    }

