﻿namespace _06.TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Numerics;

    public class TruckTour
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long pumpNo = 0;
            long pumpNo1 = 0;
            Queue<string> pumps = new Queue<string>();

            for (int j = 0; j < n; j++)
            {
                pumps.Enqueue(Console.ReadLine());
            }
            bool isALLPathValid = true;
            long allFuel = 0;
            while (pumps.Count > 0)
            {
                long currentFuel = 0;
                long[] current = pumps.Dequeue()
                    .Split(' ')
                    .Select(long.Parse)
                    .ToArray();
                currentFuel = current[0] - current[1];
                allFuel += currentFuel;

                if (allFuel < 0)
                {
                    pumpNo1 = pumpNo;
                    allFuel = 0;
                    isALLPathValid = false;
                }

                pumpNo++;
            }

            if (pumpNo1 + 1 == n || isALLPathValid)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(pumpNo1 + 1);
            }
        }
    }
}

          




