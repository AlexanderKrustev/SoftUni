using System;
using System.Collections.Generic;

class RandomizeTheNumbers1N
    {
        static void Main(string[] args)
        {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        List<int> numbersRandom = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }
        Random rdn = new Random();
        while (numbers.Count > 0) { 
            int randomIndex = rdn.Next(0, numbers.Count);
          //  Console.WriteLine(randomIndex);
            numbersRandom.Add(numbers[randomIndex]);
            numbers.RemoveAt(randomIndex);
        }
        foreach(int p in numbersRandom)
        {
            Console.Write("{0} ",p);
        }
    }
    }

