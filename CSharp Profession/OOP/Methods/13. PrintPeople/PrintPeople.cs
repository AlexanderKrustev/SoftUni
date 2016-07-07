namespace _13.PrintPeople
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Person> p=new List<Person>();
            while (!input.Equals("END"))
            {
                string[] parameters = input.Split(' ');
                string name = parameters[0];
                int age = int.Parse(parameters[1]);
                string job = parameters[2];

                p.Add(new Person(name,job, age));

                input = Console.ReadLine();
            }

            p.Sort();

            foreach (var person in p)
            {
                Console.WriteLine(person);
            }

        }
    }

    public class Person : IComparable<Person>
    {
        public string name;
        public string job;
        public int age;


        public Person(string name, string job, int age)
        {
            this.name = name;
            this.job = job;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{this.name} - age: {this.age}, occupation: {this.job}";
        }

       

        public int CompareTo(Person obj)
        {
            return this.age.CompareTo(obj.age);
        }

       
    }

}
