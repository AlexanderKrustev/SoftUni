using System;
using System.Collections;
using System.Collections.Generic;

class HalfSum
    {
        static void Main(string[] args)
        {
        List<int> numbers = new List<int>();
        int n = int.Parse(Console.ReadLine());
        for( int x=0; x < n * 2; x++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        int sum1 = 0;
        int sum2 = 0;
        for(int x=0; x<n;x++)
        {
            sum1 = sum1 + numbers[x];
        }
        for(int x= n;x<2* n; x++)
        {
            sum2 = sum2 + numbers[x];
        }
        if (sum1 == sum2)
        {
            Console.WriteLine("Yes, sum={0}",sum1);
        }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs(sum1-sum2));
        }
        }
    }

