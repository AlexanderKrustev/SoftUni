using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program    //Towel
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char background = char.Parse(Console.ReadLine());
            char rhombus = char.Parse(Console.ReadLine());
            int height = (size * 4) + 1;
            int weidt = height;
            
            Console.Write(new string(background, size));
            Console.Write(new string(rhombus, 1));
            Console.Write(new string(background, weidt - (2 * size) - 2));
            Console.Write(new string(rhombus, 1));
            Console.Write(new string(background, size));
            Console.WriteLine();
            int counterRh = 1;
            int counterBk = 1;
            for (int x =0; x < size  - 1; x++)
            {
                
                Console.Write(new string(background, size-counterBk));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, x+counterRh));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, weidt -(4 + (2*(counterRh+ x)) +(2* (size - counterBk)))));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, x + counterRh));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, size-counterBk));
                Console.WriteLine();
                counterBk++;
                counterRh++;
            }
            Console.Write(new string(rhombus, 1));
            Console.Write(new string(background, (size*2)-1));
            Console.Write(new string(rhombus, 1));
            Console.Write(new string(background, (size * 2) - 1));
            Console.Write(new string(rhombus, 1));
            Console.WriteLine();
            counterBk = counterBk-1;
            counterRh = counterRh-2;
            for (int x = size-1; x > 0; x--)
            {
                Console.Write(new string(background, size - counterBk));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, x + counterRh));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, weidt - (4 + (2 * (counterRh + x)) + (2 * (size - counterBk)))));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, x + counterRh));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, size - counterBk));
                Console.WriteLine();
                counterBk--;
                counterRh--;

            }
            Console.Write(new string(background, size));
            Console.Write(new string(rhombus, 1));
            Console.Write(new string(background, weidt - (2 * size) - 2));
            Console.Write(new string(rhombus, 1));
            Console.Write(new string(background, size));
            Console.WriteLine();
             counterRh = 1;
             counterBk = 1;
            for (int x = 0; x < size - 1; x++)
            {

                Console.Write(new string(background, size - counterBk));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, x + counterRh));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, weidt - (4 + (2 * (counterRh + x)) + (2 * (size - counterBk)))));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, x + counterRh));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, size - counterBk));
                Console.WriteLine();
                counterBk++;
                counterRh++;
            }
            Console.Write(new string(rhombus, 1));
            Console.Write(new string(background, (size * 2) - 1));
            Console.Write(new string(rhombus, 1));
            Console.Write(new string(background, (size * 2) - 1));
            Console.Write(new string(rhombus, 1));
            Console.WriteLine();
            counterBk = counterBk - 1;
            counterRh = counterRh - 2;
            for (int x = size - 1; x > 0; x--)
            {
                Console.Write(new string(background, size - counterBk));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, x + counterRh));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, weidt - (4 + (2 * (counterRh + x)) + (2 * (size - counterBk)))));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, x + counterRh));
                Console.Write(new string(rhombus, 1));
                Console.Write(new string(background, size - counterBk));
                Console.WriteLine();
                counterBk--;
                counterRh--;

            }
            Console.Write(new string(background, size));
            Console.Write(new string(rhombus, 1));
            Console.Write(new string(background, weidt - (2 * size) - 2));
            Console.Write(new string(rhombus, 1));
            Console.Write(new string(background, size));
            Console.WriteLine();

        }

    }
}
