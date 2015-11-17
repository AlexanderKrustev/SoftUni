using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class NewHouse
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int roofRows = n / 2;
        int roofDash = (n-1)/2;
        int roofAsterix = 1;
        Console.Write(new string('-', roofDash));
        Console.Write(new string('*', 1));
        Console.Write(new string('-', roofDash));
        roofDash--;
        Console.WriteLine();
        for (int x = 1; x <= roofRows-1; x++)
        {
            roofAsterix = roofAsterix + 2;
            Console.Write(new string('-',roofDash));
            Console.Write(new string('*', roofAsterix));
            Console.Write(new string('-', roofDash));
            Console.WriteLine();
            roofDash--;
           // roofAsterix = roofAsterix + 2;
        }
        
        Console.Write(new string('*', n));
        Console.WriteLine();
        for (int x=0; x< n; x++)
        {
            Console.Write(new string('|', 1));
            Console.Write(new string('*', n-2));
            Console.Write(new string('|', 1));
            Console.WriteLine();
        }
        }
    }

