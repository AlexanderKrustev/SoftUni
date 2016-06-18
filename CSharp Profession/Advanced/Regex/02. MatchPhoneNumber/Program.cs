namespace _02.MatchPhoneNumber
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<string> names = new List<string>();
            while (!input.Equals("end"))
            {
                names.Add(input);
                input = Console.ReadLine();
            }

            string pattern = @"\+359([\s-])[\d]{1}\1[\d]{3}\1[\d]{4}$";

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

