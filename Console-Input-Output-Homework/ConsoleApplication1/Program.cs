using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main()
        {
            Console.Write("Input length of the figure: ");
            string input;
            input = Console.ReadLine();
            int num = Convert.ToInt16(input);

            for (int i = 0; i <= num; i += 1)
            {
                string k = new string('M', i);
                string j = new string(' ', num - i);
                Console.Write(j);
                Console.Write(k, i);
                Console.Write(" | ");
                Console.WriteLine(k, i);
            }

            string hh = new string(' ', num);
            string hhh = new string('-', 1 + num);
            Console.Write(hh);
            Console.WriteLine(" | ");
            Console.Write(hhh);
            Console.Write("O");
            Console.WriteLine(hhh);
            Console.Write(hh);
            Console.WriteLine(" | ");

            for (int i = 0; i <= num; i += 1)
            {
                string k = new string('W', num - i);
                string j = new string(' ', i);
                Console.Write(j);
                Console.Write(k, num - i);
                Console.Write(" | ");
                Console.WriteLine(k, num - i);
            }
        }
    }
}
