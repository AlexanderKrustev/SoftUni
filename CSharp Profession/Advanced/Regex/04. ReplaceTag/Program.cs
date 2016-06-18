namespace _04.ReplaceTag
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<string> result=new List<string>();
            while (!input.Equals("end"))
            {
                
                string output = Regex.Replace(input, "<a", "[URL");
                output = Regex.Replace(output, "</a>", "[/URL]");
                output = Regex.Replace(output, "\">", "\"]");
                result.Add(output);
                input = Console.ReadLine();
            }

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
