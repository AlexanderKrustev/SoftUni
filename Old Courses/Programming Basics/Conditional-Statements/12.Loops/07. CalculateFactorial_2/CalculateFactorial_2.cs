using System;
using System.Numerics;

class CalculateFactorial_2
    {
        static void Main()
        {
        Console.WriteLine("Please eneter n in range 1<k<n<100");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please eneter k in range 1<k<n<100");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger facrotialK = 1;
        BigInteger factorialNK = 1;
        for (int i = 1; i <= (n-k); i++)
        {
            factorialNK *= i;
        }
     
        for (int i = 1; i <= n; i++)
        {
            factorialN = factorialN * i;
            if (i <= k)
            {
                facrotialK = facrotialK * i;

            }
        }
        BigInteger result = factorialN / (facrotialK*factorialNK);
        Console.WriteLine(result);
    }
    }

