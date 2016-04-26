using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int x = i; x < n+i; x++)
            {
                Console.Write(x);
            }
            Console.WriteLine();
        }
    }
    }

