namespace _08.WeakStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class WeakStudents
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

            foreach (var kvp in listOfStudents.Where(x=>x.Value.Count(i => i <= 3) >= 2))
            {
               
                Console.WriteLine($"{kvp.Key}");
            }
        }
    }
}
