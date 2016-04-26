using System;
using System.Collections.Generic;

class DecimalToBinaryNumber
    {
        static void Main()
        {
        long n = long.Parse(Console.ReadLine());
        string result = "";
        List<int> bin = new List<int>();
        while (n > 0)
        {
           bin.Add((int)n % 2);
            n /= 2;
           
        }
        for(int x = bin.Count - 1; x >= 0; x--)
        {
           
            result += bin[x];
        }
        Console.WriteLine(result);
        }
    }

