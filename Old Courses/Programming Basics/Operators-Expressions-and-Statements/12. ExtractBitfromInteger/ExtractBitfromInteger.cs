using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitfromInteger
{
    class ExtractBitfromInteger
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Index p= ");
            int p = int.Parse(Console.ReadLine());
            n = n >> p;
            Console.WriteLine("bit @ index p={0}", n & 1);
        }
    }
}
