using System;
using System.Collections.Generic;
using System.Linq;

class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        List<string> items = new List<string>();
        List<string> itemsSame = new List<string>();

        Dictionary<string, int> dict = new Dictionary<string, int>();
        int maxSeq = 0;
        

        for (int x = 0; x < n; x++)
        {
            string input = Console.ReadLine();
            if (!dict.ContainsKey(input))
            {
                
                dict.Add(input, 1);
            }
            else
            {
                dict[input] = dict[input] + 1;
            }

        }
        foreach (KeyValuePair<string, int> kvp in dict)
        {

            if (kvp.Value > maxSeq)
            {
                maxSeq = kvp.Value;
            }
        }
        foreach (KeyValuePair<string, int> kvp in dict)
        {

            if (kvp.Value== maxSeq)
            {
                Console.WriteLine(maxSeq);
                for(int z=0;z< kvp.Value;z++)
                {
                    Console.WriteLine(kvp.Key);
                }
                break;
            }
        }

    }
}

