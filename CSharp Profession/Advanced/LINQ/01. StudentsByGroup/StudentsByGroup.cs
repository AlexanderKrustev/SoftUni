namespace _01.StudentsByGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByGroup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<int,List<string>> listOfStudents = new Dictionary<int, List<string>>();
            while (!input.Equals("END"))
            {
                string[] pars = input.Split(' ');
                int group = int.Parse(pars[2]);
                if (listOfStudents.ContainsKey(group))
                {
                    listOfStudents[group].Add(pars[0]+" "+pars[1]);
                }
                else
                {
                    listOfStudents.Add(group, new List<string>());
                    listOfStudents[group].Add(pars[0] + " " + pars[1]);
                }

                input = Console.ReadLine();
            }
            
            foreach (var kvp in listOfStudents.Where(x => x.Key==2))
            {
                foreach (var s in listOfStudents[kvp.Key].OrderBy(x=>x))
                {
                    Console.WriteLine($"{s}");
                }
                
            }
            
        }
    }
}
