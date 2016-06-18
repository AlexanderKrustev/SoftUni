using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MatchFullName
{
    using System.Text.RegularExpressions;

    class MatchFullName
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> names=new List<string>();
            while (!input.Equals("end"))
            {
                names.Add(input);
                input = Console.ReadLine();
            }

            string pattern = @"([A-Z]{1}[a-z]+\s[A-Z]{1}[a-z]+)";

            foreach (string lines in names)
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(lines);
                foreach (Match m in matches)
                {
                    Console.WriteLine(m.Groups[0]);
                }
                
            }
        }
    }
}
