using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write(new string('.', (3 * n) / 2));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', (3 * n) / 2));
        Console.WriteLine();
        int fullrow = 0;
        for (int x = 1; x <= n - 1; x++)
        {
            Console.Write(new string('.', x));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', ((3 * n) / 2) - (x + 1)));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', ((3 * n) / 2) - (x + 1)));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', x));
            Console.WriteLine();
            fullrow = ((3 * n) / 2) - (x + 1);
        }
        for (int x = 1; x <= fullrow; x++)
        {

            Console.Write(new string('.', n));
            Console.Write(new string('*', n));
            Console.Write(new string('.', n));
            Console.WriteLine();
        }
        Console.Write(new string('*', 3*n));
        Console.WriteLine();
        for (int x = 1; x <= fullrow; x++)
        {

            Console.Write(new string('.', n));
            Console.Write(new string('*', n));
            Console.Write(new string('.', n));
            Console.WriteLine();
        }
        for (int x = n-1; x >=1; x--)
        {
            Console.Write(new string('.', x));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', ((3 * n) / 2) - (x + 1)));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', ((3 * n) / 2) - (x + 1)));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', x));
            Console.WriteLine();
            fullrow = ((3 * n) / 2) - (x + 1);
        }
        Console.Write(new string('.', (3 * n) / 2));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', (3 * n) / 2));
        Console.WriteLine();
    }
}

