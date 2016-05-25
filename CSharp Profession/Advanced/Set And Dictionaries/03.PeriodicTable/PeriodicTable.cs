using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> table = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] currentRow =
                    Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string str in currentRow)
                {
                    table.Add(str);
                }
            }

            Console.WriteLine(string.Join(" ", table));
        }
    }
}
