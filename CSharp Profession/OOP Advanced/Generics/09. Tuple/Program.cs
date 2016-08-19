using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split();
            string[] line2 = Console.ReadLine().Split();
            string[] line3 = Console.ReadLine().Split();

            Truple<string,string> l1=new Truple<string, string>(line1[0]+" "+line1[1], line1[2]);
            Truple<string, int> l2=new Truple<string, int>(line2[0], int.Parse(line2[1]));
            Truple<int, double> l3=new Truple<int, double>(int.Parse(line3[0]), double.Parse(line3[1]) );

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);

        }
    }
}
