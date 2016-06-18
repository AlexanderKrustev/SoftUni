namespace _03.StudentByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentByAge
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> listOfStudents = new Dictionary<string, int>();
            int cout = 0;
            while (!input.Equals("END"))
            {

                string[] pars = input.Split(' ');
                string firstName = pars[0];
                string lastName = pars[1];
                listOfStudents.Add(firstName + " " + lastName,int.Parse(pars[2]));


                input = Console.ReadLine();
            }

            foreach (var kvp in listOfStudents.Where(x=>x.Value>=18 && x.Value<=24))
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }
        }
    }
}
