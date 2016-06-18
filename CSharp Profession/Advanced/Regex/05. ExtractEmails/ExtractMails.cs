namespace _05.ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ExtractMails
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> mails = new List<string>();
            
            string pattern = @"\s([A-Za-z]+[\.\-_]?[A-z]+@[A-z-]+\.([A-z]+)(\.?[A-z]+)?)";
//([a-z]+[\.\-_]?[a-z]+@[a-z-]+\.([a-z]+)(\.?[a-z]+)?)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Groups[1]);
            }

        }
    }
}
