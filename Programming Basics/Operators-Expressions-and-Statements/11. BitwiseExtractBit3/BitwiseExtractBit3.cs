using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
        uint n = uint.Parse(Console.ReadLine());
        n = n >> 3;
        Console.WriteLine(n & 1);
        }
    }

