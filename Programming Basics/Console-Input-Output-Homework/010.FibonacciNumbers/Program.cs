using System;
using System.Collections.Generic;

class Program
    {
        static void Main()
        {
        Console.WriteLine("n= ");
        int n = int.Parse(Console.ReadLine());
        List<int> fibNumbers = new List<int>();
        fibNumbers.Add(0);
        fibNumbers.Add(1);
        for (int x=2 ; x< n ; x++)
        {
            fibNumbers.Add(fibNumbers[x - 2] + fibNumbers[x - 1]);
            
        }
        foreach (int y in fibNumbers){
            Console.Write("{0} ",y);
        }
        Console.WriteLine();

    }
    }

