namespace Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list=new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] nameage = Console.ReadLine().Split(' ');
                var p=new Person(nameage[0], int.Parse(nameage[1]));
                list.Add(p);
            }

            foreach (var person in list.OrderBy(x=>x.Name).Where(y=>y.Age>30))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }

    
}
