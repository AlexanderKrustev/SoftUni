using System;
using System.Numerics;

class CatalanNumbers
    {
        static void Main()
        {
        Console.WriteLine("Please eneter n in range 1<n<100");
        int n = int.Parse(Console.ReadLine());
        double c = 1;
        BigInteger factorialN = 1;
        BigInteger factorial2N = 1;
        BigInteger factorialN1 = 1;
        for (int i = 1; i <=2*n; i++)
        {
            factorial2N = factorial2N * i;
            if (i <= n)
            {
                factorialN = factorialN * i;
            }
            if (i <= n + 1)
            {
                factorialN1 = factorialN1 * i;
            }
        }
        BigInteger result = factorial2N / (factorialN1 * factorialN);
        Console.WriteLine(result);
    }
    }

