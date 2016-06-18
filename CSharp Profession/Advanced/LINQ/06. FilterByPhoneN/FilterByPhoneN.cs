namespace _06.FilterByPhoneN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterByPhoneN
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
                listOfStudents.Add(firstName + " " + lastName, pars[2]);


                input = Console.ReadLine();
            }

            foreach (var kvp in listOfStudents.Where(x => x.Value.StartsWith("02") || x.Value.StartsWith("+3592")))
            {
                Console.WriteLine($"{kvp.Key}");
            }
        }
    }
}
