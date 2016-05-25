namespace _14.DragonArmy
{
    using System;
    using System.Collections.Generic;

    public class DragonArmy
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, SortedDictionary<string, List<int>>> data =new Dictionary<string, SortedDictionary<string, List<int>>>();

            for (int i = 0; i < n; i++)
            {

                string[] parameters = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                string type = parameters[0];
                string name = parameters[1];
                int damage = 0;
                int health = 0;
                int armor = 0;
                if (parameters[2].Equals("null"))
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(parameters[2]);
                }
                if (parameters[3].Equals("null"))
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(parameters[3]);
                }
                if (parameters[4].Equals("null"))
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(parameters[4]);
                }

                if (data.ContainsKey(type))
                {
                    if (data[type].ContainsKey(name))
                    {
                        data[type][name].Clear();
                        data[type][name].Add(damage);
                        data[type][name].Add(health);
                        data[type][name].Add(armor);
                    }
                    else
                    {
                        data[type].Add(name, new List<int>());
                        data[type][name].Add(damage);
                        data[type][name].Add(health);
                        data[type][name].Add(armor);
                    }
                }
                else
                {
                    data.Add(type, new SortedDictionary<string, List<int>>());
                    data[type].Add(name, new List<int>());
                    data[type][name].Add(damage);
                    data[type][name].Add(health);
                    data[type][name].Add(armor);
                }
            }

            foreach (KeyValuePair<string, SortedDictionary<string, List<int>>> kvp in data)
            {
                double avarageDMG = 0;
                double avarageH = 0;
                double avarageA = 0;
                int counter = 0;
                foreach (KeyValuePair<string, List<int>> kvp2 in data[kvp.Key])
                {
                    avarageDMG += kvp2.Value[0];
                    avarageH += kvp2.Value[1];
                    avarageA += kvp2.Value[2];
                    counter++;
                }
                avarageDMG = avarageDMG/ counter;
                avarageA = avarageA / counter;
                avarageH = avarageH / counter;
                Console.WriteLine("{0}::({1:0.00}/{2:0.00}/{3:0.00})", kvp.Key, avarageDMG, avarageH, avarageA);
                foreach (KeyValuePair<string, List<int>> kvp1 in data[kvp.Key])
                {
                    Console.WriteLine($"-{kvp1.Key} -> damage: {kvp1.Value[0]}, health: {kvp1.Value[1]}, armor: {kvp1.Value[2]}");
                }
            }
        }
    }
}
