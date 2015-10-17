using System;
using System.Collections.Generic;

class SortingNumbers
    {
        static void Main(string[] args)
        {
        List<int> number = new List<int>();
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        for(int x=0; x< n; x++)
        {
            number.Add(int.Parse(Console.ReadLine()));
        }
        number.Sort();
        foreach(int k in number)
        {
            Console.WriteLine(k);
        }
        }
    }

