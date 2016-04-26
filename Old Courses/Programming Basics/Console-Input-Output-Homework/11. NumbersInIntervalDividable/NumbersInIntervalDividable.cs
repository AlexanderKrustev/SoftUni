using System;
using System.Collections.Generic;

class NumbersInIntervalDividable
{
    static void Main()
    {
        Console.Write("Start= ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("End= ");
        int end = int.Parse(Console.ReadLine());
        int counter=0;
        for(int x= start;x<= end; x++)
        {
            if (x % 5 == 0)
            {
                Console.Write("{0}, ",x);
                counter++;
            }
            
        }
        Console.WriteLine("\n{0}",counter);
        
    }

    }

