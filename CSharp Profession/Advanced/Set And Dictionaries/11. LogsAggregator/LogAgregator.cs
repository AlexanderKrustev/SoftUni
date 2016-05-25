using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LogsAggregator
{
    using System.Runtime.InteropServices;

    public class LogAgregator
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, int> userDuration = new SortedDictionary<string, int>();
            SortedDictionary<string, SortedSet<string>> userIP = new SortedDictionary<string, SortedSet<string>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (!userIP.ContainsKey(input[1]))
                {
                    userIP.Add(input[1], new SortedSet<string>());
                    userDuration.Add(input[1], int.Parse(input[2]));
                    userIP[input[1]].Add(input[0]);
                }
                else
                {
                    userIP[input[1]].Add(input[0]);
                    userDuration[input[1]] += int.Parse(input[2]);
                }
            }

            foreach (KeyValuePair<string,SortedSet<string>> kvp in userIP)
            {
                Console.Write($"{kvp.Key}: {userDuration[kvp.Key]} [");
                Console.Write(string.Join(", ", kvp.Value));
                Console.WriteLine("]");
            }
        }
    }
}
