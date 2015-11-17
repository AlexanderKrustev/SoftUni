using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class ExamBitSifting
    {
        static void Main()
        {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        int sieveCount = int.Parse(Console.ReadLine());
        List<BigInteger> sieves = new List<BigInteger>();
        for(int z = 0; z < sieveCount; z++)
        {
            sieves.Add(BigInteger.Parse(Console.ReadLine()));
        }
        BigInteger result = 0;
        if (sieveCount != 0)
        {
            result = n & ~sieves[0];
            for (int z = 1; z < sieveCount; z++)
            {
                result = result & ~sieves[z];
            }
        }
        else
        {
            result = n;
        }
        BigInteger mask = 1;
        BigInteger bitCheck = 0;
        int onesCounter=0;
        for(int x=0; x < 64; x++)
          {
            bitCheck = result & (mask << x);
            bitCheck = bitCheck >> x;
            if (bitCheck == 1)
            {
                onesCounter++;
            }
          }
        Console.WriteLine(onesCounter);
    }
    }

