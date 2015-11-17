using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class DivideBy7And5
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 5 == 0 && n % 7 == 0  && n!=0);
    }
    }

