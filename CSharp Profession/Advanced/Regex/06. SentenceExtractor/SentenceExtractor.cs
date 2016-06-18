namespace _06.SentenceExtractor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class SentenceExtractor

    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = @"([\w\d\s-`'"""":;)({}[\]’–]+[!\.?]{1})";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match m in matches)
            {
                List<string> words = new List<string>();
                words= m.ToString().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (words.Contains(key))
                {
                    Console.WriteLine(m.Groups[1].ToString());
                }
            }
        }

    }
}
