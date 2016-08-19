
using System;
using System.Collections.Generic;
using System.Text;

namespace _12.TreeTuple
{
    public class StartUp
    {
        static void Main()
        {
            

            string[] inputRow1 = Console.ReadLine().Split();
            ThreeTuple<string, string, string> t1= new ThreeTuple<string, string, string>(inputRow1[0]+" "+inputRow1[1],inputRow1[2],inputRow1[3]);
            string[] inputRow2 = Console.ReadLine().Split();
            bool arg = false;
            if (inputRow2[2] == "drunk")
            {
                arg = true;
            }
            ThreeTuple<string, int, bool> t2 = new ThreeTuple<string, int, bool>(inputRow2[0], int.Parse(inputRow2[1]), arg );
            string[] inputRow3 = Console.ReadLine().Split();
            ThreeTuple<string, double, string> t3 = new ThreeTuple<string, double, string>(inputRow3[0], double.Parse(inputRow3[1]), inputRow3[2]);

            Console.WriteLine($"{t1.Key} -> {t1.FirstValue} -> {t1.SecondValue}");
            Console.WriteLine($"{t2.Key} -> {t2.FirstValue} -> {t2.SecondValue}");
            Console.WriteLine("{0} -> {1:f1} -> {2}",t3.Key,t3.FirstValue,t3.SecondValue);
        }
    }
}
