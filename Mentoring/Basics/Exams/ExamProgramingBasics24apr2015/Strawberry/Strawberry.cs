using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strawberry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n/2; i++)
            {

                Console.Write(new string('-', i*2));
                Console.Write(new string('\\',1));
                Console.Write(new string('-', n-(i*2)));
                Console.Write(new string('|', 1));
                Console.Write(new string('-', n - (i * 2)));
                Console.Write(new string('/', 1));
                Console.Write(new string('-', (i * 2)));
                Console.WriteLine();
            }
         
            for (int i = 0; i < n/2+1; i++)
            {
                Console.Write(new string('-', n-i*2));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', i * 4 + 1));
                Console.Write(new string('#', 1));
                Console.Write(new string('-', n-i*2));
                Console.WriteLine();
            }
            Console.Write(new string('#', 1));
            Console.Write(new string('.', n*2+1));
            Console.Write(new string('#', 1));
            Console.WriteLine();
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('-', 1+i));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', (n * 2 - 1)-i*2));
                Console.Write(new string('#', 1));
                Console.Write(new string('-', 1 + i ));
                Console.WriteLine();
            }

            Console.Write(new string('-', n));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', 1));
            Console.Write(new string('#', 1));
            Console.Write(new string('-', n));
            Console.WriteLine();
        }
    }
}
