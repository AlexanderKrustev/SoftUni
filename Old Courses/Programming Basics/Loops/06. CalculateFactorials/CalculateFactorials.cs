using System;

    class CalculateFactorials
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please eneter n in range 1<k<n<100");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please eneter k in range 1<k<n<100");
        int k = int.Parse(Console.ReadLine());
        int factorialN = 1;
        int facrotialK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN = factorialN * i;
            if (i <= k)
            {
                facrotialK = facrotialK * i;

            }
        }
        double result = factorialN / facrotialK;
        Console.WriteLine(result);
    }
    }

