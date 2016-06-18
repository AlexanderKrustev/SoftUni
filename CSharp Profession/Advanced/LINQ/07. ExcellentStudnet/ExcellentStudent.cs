namespace _07.ExcellentStudnet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;

    class ExcellentStudent
    {
        static void Main()
        {
            Dictionary<string, List<int>> listOfStudents = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();
            while (!input.Equals("END"))
            {

                string[] pars = input.Split(' ');
                string firstName = pars[0];
                string lastName = pars[1];
                listOfStudents.Add(firstName + " " + lastName, new List<int>());

                for (int i = 2; i < pars.Length; i++)
                {
                    listOfStudents[firstName + " " + lastName].Add(int.Parse(pars[i]));
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in listOfStudents.Where(x=>x.Value.Contains(6)))
            {
                Console.WriteLine($"{kvp.Key}");
            }
        }
    }
}
