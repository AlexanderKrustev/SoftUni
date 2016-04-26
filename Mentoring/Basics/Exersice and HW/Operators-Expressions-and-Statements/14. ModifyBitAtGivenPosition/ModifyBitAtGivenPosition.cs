using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
        Console.Write("n= ");
        short n = short.Parse(Console.ReadLine());
        Console.Write("Index p= ");
        short p = short.Parse(Console.ReadLine());
        Console.Write("Value v= ");
        short v = short.Parse(Console.ReadLine());
        int checkBit = n >> p;
        int mask = 1;
        checkBit = checkBit & 1;
        int result = 0;
        if (checkBit == v)
        {
            Console.Write("Binary Result:");
            Console.WriteLine(Convert.ToString(n,2).PadLeft(16,'0'));
            Console.WriteLine("Decimal Result:{0}",n);
        }
        else
        {
            if (checkBit == 0)
            {
                mask = mask << p;
                result = n | mask;
                Console.Write("Binary Result:");
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(16,'0'));
                Console.WriteLine("Decimal Result:{0}", result);
            }
            else
            {
                mask = ~(mask << p);
                result = n & mask;
                Console.Write("Binary Result:");
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
                Console.WriteLine("Decimal Result:{0}", result);
            }
        }

        }
    }

