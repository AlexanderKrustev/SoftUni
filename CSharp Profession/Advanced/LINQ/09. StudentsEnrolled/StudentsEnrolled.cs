namespace _09.StudentsEnrolled
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsEnrolled
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> listOfStudents = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();
            while (!input.Equals("END"))
            {

                string[] pars = input.Split(' ');
                string fk = pars[0];
             
                listOfStudents.Add(fk, new List<int>());

                for (int i = 1; i < pars.Length; i++)
                {
                    listOfStudents[fk].Add(int.Parse(pars[i]));
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in listOfStudents.Where(x => x.Key.EndsWith("14") || x.Key.EndsWith("15")))
            {
                Console.WriteLine(string.Join(" ", kvp.Value));
            }
        }
    }
}
