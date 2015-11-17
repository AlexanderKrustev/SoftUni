using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BitsExchange
    {
        static void Main()
        {
        uint n= uint.Parse(Console.ReadLine());
        uint firstGroupBits = (n >> 3) & 7;
        uint secondGroupBits = (n >> 24) & 7;
        uint maskFirstBits = 7 << 3;
        uint maskSecondBits = 7 << 24;
        n = n & ~maskFirstBits | (secondGroupBits << 3);
        n = n & ~maskSecondBits | (firstGroupBits << 24);
        Console.WriteLine("Result: {0}", n);
        Console.WriteLine("Binary representation of result: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
    }
    }
