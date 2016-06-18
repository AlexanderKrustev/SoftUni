namespace _08.ExtractHyperlinks
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class ExtractHyperlinks
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> inp=new List<string>();
            while (!input.Equals("END"))
            {
                inp.Add(input);
                input = Console.ReadLine();
            }

            string pattern = @"<a(.+?)\s?href\s*=\s*(""|')(.+?)\2";
            Regex regex = new Regex(pattern);

            foreach (var line in inp)
            {
                var matches = regex.Matches(line);
                foreach (Match m in matches)
                {
                    Console.WriteLine(m.Groups[1]);
                }
            }

            var a = 0;
        }
    }
}
