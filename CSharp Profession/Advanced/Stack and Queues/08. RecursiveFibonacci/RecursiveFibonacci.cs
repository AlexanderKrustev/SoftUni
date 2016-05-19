using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RecursiveFibonacci
{
    public class RecursiveFibonacci
    {
        public static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            GetFibonacci(n);
            Console.WriteLine(calculatedF[n]);
         

        }

        public static Dictionary<int, long> calculatedF = new Dictionary<int, long>();

        

        public static long GetFibonacci(int n)
        {

            if (n == 0)
            {
                if (!calculatedF.ContainsKey(0))
                {
                    calculatedF.Add(0, 0);
                }
                return calculatedF[0];
            }
            if (n == 1)
            {
                if (!calculatedF.ContainsKey(1))
                {
                    calculatedF.Add(1, 1);
                }
                return calculatedF[1];

            }

             if (calculatedF.ContainsKey(n))
            {
                return calculatedF[n];
            }
            else
            {
                long f = GetFibonacci(n - 1) + GetFibonacci(n - 2);
                calculatedF[n] = f;

                return f;
            }

        }
    }
}

