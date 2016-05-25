using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PopulationCounter
{
   public class PopulationCounter
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (!input.Equals("report"))
            {
                string[] arguments = input.Split(new[] {'|'});

                if (!data.ContainsKey(arguments[1]))
                {
                    data.Add(arguments[1], new Dictionary<string, long>());
                    data[arguments[1]].Add(arguments[0], long.Parse(arguments[2]));
                }
                else
                {
                    if (data[arguments[1]].ContainsKey(arguments[0]))
                    {

                        data[arguments[1]][arguments[0]] += long.Parse(arguments[2]);
                    }
                    else
                    {
                        data[arguments[1]].Add(arguments[0], long.Parse(arguments[2]));
                    }
                }

                input = Console.ReadLine();
            }

           

            foreach (KeyValuePair<string, Dictionary<string, long>> kvp in data.OrderByDescending(key =>key.Value.Values.Sum()))
            {
                var items = from pair in kvp.Value
                            orderby pair.Value descending 
                            select pair;
              

                Console.WriteLine($"{kvp.Key} (total population: {data[kvp.Key].Values.Sum()})");

                foreach (KeyValuePair<string, long> cities in kvp.Value.OrderByDescending(key => key.Value))
                {
                    Console.WriteLine($"=>{cities.Key}: {cities.Value}");
                }
            }
        }
    }
}
