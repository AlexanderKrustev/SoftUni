using System;

    class NumbersNotDivisible3and7
    {
        static void Main()
        {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (i % 7 != 0 && i % 3 != 0)
            {  
                Console.Write("{0} ",i);
            
            }
        }
        Console.WriteLine();
       
    }
    }

