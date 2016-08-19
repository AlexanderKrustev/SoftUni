namespace _10.ExplicitInterfaces
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class ExplicitInterfaces
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IPerson> people = new List<IPerson>();
            List<IPresident> presidents = new List<IPresident>();
            while (!input.Equals("End"))
            {
                string[] parameters = input.Split();
                string name = parameters[0];
                string country = parameters[1];
                int age = int.Parse(parameters[2]);
                people.Add(new Citizen(name,country,age));
                presidents.Add(new Citizen(name,country,age));

                input = Console.ReadLine();
            }

            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].GetName());
                Console.WriteLine(presidents[i].GetName());
            }
        }
    }
}
