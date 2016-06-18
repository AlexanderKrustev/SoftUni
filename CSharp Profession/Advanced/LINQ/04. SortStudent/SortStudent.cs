namespace _04.SortStudent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortStudent
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> listOfStudents = new List<string>();
            int cout = 0;
            while (!input.Equals("END"))
            {

                string[] pars = input.Split(' ');
                string firstName = pars[0];
                string lastName = pars[1];
                listOfStudents.Add(firstName + " " + lastName);


                input = Console.ReadLine();
            }


            var selected =
                listOfStudents.Select(x => x.Split()).OrderByDescending(i => i[0]).OrderBy(y => y[1]).Select(n=>n[0]+" "+n[1]).ToList();

            foreach (var name in selected)
            {
                Console.WriteLine(name);
            }
           
        }
    }
}
