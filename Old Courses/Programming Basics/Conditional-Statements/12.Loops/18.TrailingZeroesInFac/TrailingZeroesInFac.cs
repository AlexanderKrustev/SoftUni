using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TrailingZeroesInFac
{
    class TrailingZeroesInFac
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            long factorial = 1;
            for (int i  = 1; i  <=n; i ++)
            {
                factorial *= i;
            }
            bool isZero = true;
            int zeroCounter = 0;
            do
            {
                if (factorial % 10 == 0)
                {
                    zeroCounter++;
                    factorial = factorial / 10;                }
                else
                {
                    isZero = false;
                }
            } while (isZero);
            Console.WriteLine(zeroCounter);
        }
    }
}
