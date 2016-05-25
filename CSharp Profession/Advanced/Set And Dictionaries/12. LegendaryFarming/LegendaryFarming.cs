using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.LegendaryFarming
{
    using System.Numerics;
  

    public class LegendaryFarming
    {
        public static void Main(string[] args)
        {

            bool isObtained = false;
            string input = Console.ReadLine();
            SortedDictionary<string, BigInteger> mats = new SortedDictionary<string, BigInteger>();
            SortedDictionary<string, BigInteger> junk = new SortedDictionary<string, BigInteger>();
            mats.Add("fragments",0);
            mats.Add("motes", 0);
            mats.Add("shards", 0);
            while (!isObtained){
              

                string[] materials =
                    input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();

                for (int i = 0; i < materials.Length - 1; i = i + 2)
                {
                    if (isMaterial(materials[i + 1]))
                    {
                        mats[materials[i + 1]] += int.Parse(materials[i]);
                        if (mats[materials[i + 1]] >= 250)
                        {
                            if (materials[i + 1].Equals("shards"))
                            {
                                mats[materials[i + 1]] -= 250;
                                Console.WriteLine("Shadowmourne obtained!");
                                isObtained = true;

                                break;
                            }
                            if (materials[i + 1].Equals("motes"))
                            {
                                mats[materials[i + 1]] -= 250;
                                Console.WriteLine("Dragonwrath obtained!");
                                isObtained = true;
                                break;
                            }
                            if (materials[i + 1].Equals("fragments"))
                            {
                                mats[materials[i + 1]] -= 250;
                                Console.WriteLine("Valanyr obtained!");
                                isObtained = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(materials[i + 1]))
                        {
                            junk[materials[i + 1]] += BigInteger.Parse(materials[i]);
                        }
                        else
                        {
                            junk.Add(materials[i + 1], BigInteger.Parse(materials[i]));
                        }
                    }
                    
                }
                if (isObtained)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            foreach (KeyValuePair<string, BigInteger> mt in mats.OrderByDescending(value => value.Value))
            {
                Console.WriteLine($"{mt.Key}: {mt.Value}");
            }

            foreach (KeyValuePair<string, BigInteger> mt1 in junk)
            {
                Console.WriteLine($"{mt1.Key}: {mt1.Value}");
            }
            
         }

        public static bool isMaterial(string mat)
        {
            if (mat.Equals("shards") || mat.Equals("motes") || mat.Equals("fragments"))
            {
                return true;
            }
          
            return false;
        }

        
    }
}
