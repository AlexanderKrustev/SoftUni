using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, string> phonebook=new Dictionary<string, string>();

            while (!input.Equals("search"))
            {
                string[] phones = input.Split(new[] {'-'}).ToArray();

                if (phonebook.ContainsKey(phones[0]))
                {
                    phonebook.Remove(phones[0]);
                }
                phonebook.Add(phones[0], phones[1]);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (!input.Equals("stop"))
            {   
                
                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine("{0} -> {1}", input, phonebook[input]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.",input);
                }


                input = Console.ReadLine();
            }
        }
    }
}
