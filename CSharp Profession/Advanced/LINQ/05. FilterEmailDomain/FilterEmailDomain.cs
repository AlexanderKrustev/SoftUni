namespace _05.FilterEmailDomain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterEmailDomain
    {
        public static void Main()
        {

            Dictionary<string, string> listOfStudents = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (!input.Equals("END"))
            {

                string[] pars = input.Split(' ');
                string firstName = pars[0];
                string lastName = pars[1];
                listOfStudents.Add(firstName + " " + lastName,pars[2]);


                input = Console.ReadLine();
            }

            foreach (var kvp in listOfStudents.Where(x=>x.Value.Contains("@gmail.com")))
            {
                Console.WriteLine($"{kvp.Key}");
            }
        }
    }
}
