using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SetOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions =
                Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            HashSet<int> set1= new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < dimentions[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < dimentions[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join(" ",set1.Intersect(set2)));
            
        }
    }
}
