using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class BitExchangeAdvanced
    {  
    
       
    
        static void Main(string[] args)
        {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2));
        uint secondGroupBits = (((n << (31-(p+k))) >> 32-k-1));                          //(((n << (32 - (p + k)))>>(p+ (32 - (p + k)))));
        uint firstGroupBits =(((n << (31 -(q+k))) >> 32-k-1));
        
        firstGroupBits = firstGroupBits << p;
        secondGroupBits = secondGroupBits << q;
        //Console.WriteLine(Convert.ToString(firstGroupBits, 2).PadLeft(31, '0'));
        // Console.WriteLine(Convert.ToString(secondGroupBits, 2).PadLeft(31, '0'));
        uint result = n & ~(firstGroupBits <<q) | secondGroupBits<<q;
        result = result & ~(secondGroupBits << p) | firstGroupBits << p;
        n = n & ~(firstGroupBits << p) | firstGroupBits << p;
        n = n & ~(firstGroupBits << q) | firstGroupBits << q;
        Console.WriteLine(Convert.ToString(n, 2));
        Console.WriteLine(n);
        return;
        result = result ^ firstGroupBits;
       
        
        Console.WriteLine(Convert.ToString(firstGroupBits, 2).PadLeft(31, '0'));
         Console.WriteLine(Convert.ToString(secondGroupBits, 2).PadLeft(31, '0'));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(31, '0'));

       // result = result ^ firstGroupBits;
       // result = result ^ secondGroupBits;
        Console.WriteLine(result);
        /*    int secondGroupBits = (n >> 24) & 7;

            n = n & ~maskFirstBits | (secondGroupBits << 3);
            n = n & ~maskSecondBits | (firstGroupBits << 24);
            Console.WriteLine("Result: {0}", n);
            Console.WriteLine("Binary representation of result: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));*/
    }

    }

