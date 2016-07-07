namespace _09.Pizza
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        static void Main(string[] args)
        {
            MethodInfo[] methods = typeof(Pizza).GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Contains("SortedDictionary"));
            if (!containsMethod)
            {
                throw new Exception();
            }

            Pizza p=new Pizza();

            string[] input = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            string patternm = @"([\d]+)([\D]+)";
            Regex regex=new Regex(patternm);

            foreach (var i in input)
            {
                MatchCollection collection = regex.Matches(i);
                foreach (Match m in collection)
                {
                    string key = m.Groups[1].ToString();
                    string piz = m.Groups[2].ToString();
                    p.SortedDictionary(key,piz);
                }
            }

            Console.WriteLine(p.ToString());

        }
    }

    public class Pizza
    {
        public SortedDictionary<int, List<string>> pizzas;

        public Pizza()
        {
            this.pizzas=new SortedDictionary<int, List<string>>();
        }

        public SortedDictionary<int, List<string>> SortedDictionary(string key, string name)
        {
            int k = int.Parse(key);
            SortedDictionary < int, List < string >> re=new SortedDictionary<int, List<string>>();
            if (pizzas.ContainsKey(k))
            {
                pizzas[k].Add(name);
            }
            else
            {
                pizzas.Add(k,new List<string>());
                pizzas[k].Add(name);
            }

            return re;
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();

            foreach (var kvp in pizzas)
            {
                sb.Append(string.Format("{0} - {1}\n", kvp.Key , string.Join(", ",kvp.Value)));
            }
            return sb.ToString().TrimEnd();
        }
    }
}
