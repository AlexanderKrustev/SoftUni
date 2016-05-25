namespace _13.SrabskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text.RegularExpressions;

    public class SrabskoUnleashed
    {
        public static void Main()
        {
            Dictionary<string,Dictionary<string,BigInteger>> data = new Dictionary<string, Dictionary<string, BigInteger>>();

            string input = Console.ReadLine();



            while (!input.Equals("End"))
            {

                Match match = Regex.Match(input, @"(\D+)\s@(\D+)\s(\d+)\s(\d+)");
//([A-z]+\s{0,1}[A-z]+)\s@([A-z]+\s{0,1}[A-z]+)\s([0-9]+)\s([0-9]+)");
                    //;
               

                if (match.Success)
                {

                    string singer = match.Groups[1].ToString();
                    string venue = match.Groups[2].ToString();
                    int amountOfTickets = int.Parse(match.Groups[3].ToString());
                    BigInteger amountOfMoney = BigInteger.Parse(match.Groups[4].ToString());

                    if (data.ContainsKey(venue))
                    {
                        if (data[venue].ContainsKey(singer))
                        {
                            data[venue][singer] += amountOfMoney*amountOfTickets;
                        }
                        else
                        {
                            data[venue].Add(singer, amountOfMoney*amountOfTickets);
                        }
                    }
                    else
                    {
                        data.Add(venue, new Dictionary<string, BigInteger>());
                        data[venue].Add(singer, amountOfMoney*amountOfTickets);
                    }


                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string,Dictionary<string, BigInteger>> kvp in data)
            {
                Console.WriteLine(kvp.Key);

                foreach (KeyValuePair<string, BigInteger> kvp1 in data[kvp.Key].OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {kvp1.Key} -> {kvp1.Value}");
                }
            }
        }
    }
}
