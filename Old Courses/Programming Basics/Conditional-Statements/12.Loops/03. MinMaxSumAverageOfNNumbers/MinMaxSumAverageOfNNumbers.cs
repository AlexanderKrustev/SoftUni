using System;
using System.Collections.Generic;

class MinMaxSumAverageOfNNumbers
    {
         static void Main()
        {
            Console.Write("n= ");
            List<int> number = new List<int>();
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                number.Add( int.Parse(Console.ReadLine()));
                sum += number[i];
            if (max < number[i])
            {
                max = number[i];
            }
            if (min > number[i])
            {
                min = number[i];
            }
             }
        double avarage = (double)sum / (double)n;
        Console.WriteLine("min={0}",min);
        Console.WriteLine("max={0}",max);
        Console.WriteLine("sum={0}",sum);
        Console.WriteLine("avarage={0:f2}",avarage);
    }
    }

