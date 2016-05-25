namespace _09.UserLogs
{
    using System;
    using System.Collections.Generic;

    public class UserLog
    {
        public static void Main(string[] args)
        {

            SortedDictionary<string, Dictionary<string, int>> data =
                new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] messages = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                string ip = messages[0].Substring(3);
                string user = messages[2].Substring(5);

                if (data.ContainsKey(user))
                {
                    if (data[user].ContainsKey(ip))
                    {
                        data[user][ip]++;
                    }
                    else
                    {
                        data[user].Add(ip, 1);
                    }
                }
                else
                {
                    data.Add(user, new Dictionary<string, int>());
                    data[user].Add(ip, 1);

                }

                input = Console.ReadLine();
            }


            foreach (KeyValuePair<string, Dictionary<string, int>> kvp in data)
            {
                Console.WriteLine($"{kvp.Key}:");
                PrintIPS(data[kvp.Key]);
            }
        }


        public static void PrintIPS(Dictionary<string, int> dict)
        {
            int counter = 0;
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                counter++;
                Console.Write($"{kvp.Key} => {kvp.Value}");
                if (counter < dict.Count)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
        }
    }
}
