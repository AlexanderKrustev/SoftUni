using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSymbols
{
    using System.Data;

    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> dict=new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                {
                    dict[input[i]]++;
                }
                else
                {
                    dict.Add(input[i],1);
                }
            }
            
            foreach (KeyValuePair<char,int> kvp  in dict)
            {
                Console.WriteLine("{0}: {1} time/s",kvp.Key,kvp.Value);
            }
        }
    }
}
