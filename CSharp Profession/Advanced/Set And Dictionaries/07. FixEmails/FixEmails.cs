namespace _07.FixEmails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            Dictionary<string, string> mailsDB = new Dictionary<string, string>();
            string input = Console.ReadLine();
            int rowcounter = 1;
            string last = "";
            while (!input.Equals("stop"))
            {

                if (rowcounter%2 == 1)
                {
                    last = input;
                }
                else
                {
                    if (!mailsDB.ContainsKey(last) && !input.Substring(input.Length - 2, 2).Equals("uk") &&
                        !input.Substring(input.Length - 2, 2).Equals("us"))
                    {
                        mailsDB.Add(last, input);
                    }


                    last = "";
                }
                input = Console.ReadLine();
                rowcounter++;
            }

            foreach (KeyValuePair<string, string> kvp in mailsDB)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
        }
    }
}

