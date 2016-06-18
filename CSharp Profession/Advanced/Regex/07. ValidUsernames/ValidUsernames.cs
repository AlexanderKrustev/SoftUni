namespace _07.ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class ValidUsernames
    {
        static void Main(string[] args)
        {
          //  string input = Console.ReadLine();
              string[] input = Console.ReadLine()
                  .Split(new[] { ' ', '/', '\\', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);
            int maxLength = 0;
            string user1 = "";
            string user2 = "";
            List<string> validUser = new List<string>();
            string pattern = @"^[A-z][\w]{2,24}";
            Regex regex = new Regex(pattern);
            foreach (var str in input)
            {
                if (regex.IsMatch(str) && str.Length>=3 && str.Length<=25)
                {
                    validUser.Add(str);
                }
            }
         
         for (int i = 1; i < validUser.Count; i++)
         {
             int templength = validUser[i].Length + validUser[i - 1].Length;
             if (templength > maxLength)
             {
                 maxLength = templength;
                 user1 = validUser[i - 1];
                 user2 = validUser[i];
             }
         }
         Console.WriteLine(user1);
         Console.WriteLine(user2);
            var a = 0;
        }

    }
}

