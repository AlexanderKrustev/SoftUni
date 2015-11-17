using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Index p= ");
        int p = int.Parse(Console.ReadLine());
        n = n >> p;
        int bit = n & 1;
        bool result = bit == 1;
            Console.WriteLine("bit @ p == 1:{0}",result);
    }
}
        
    

