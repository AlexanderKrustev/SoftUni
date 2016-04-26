using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TheBiggestOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double max = 0;
            if(a > b && a >= c)
            {
                max = a;
            }
            else if(max>b && max <= c)
            {
                max = c;
            }
            else
            {
                max = b;
            }
            Console.WriteLine("Biggest one is {0}",max);
        }
    }
}
