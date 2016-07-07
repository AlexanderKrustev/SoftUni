namespace _02.OldestFamilyMember
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    class OldestFamilyMember
    {
        static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            int n = int.Parse(Console.ReadLine());
            Family f=new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                f.AddMember(new Person(name, age));
            }

            Console.WriteLine($"{f.GetOldestMember().name} {f.GetOldestMember().age}");
        }
    }

    public class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class Family
    {
        public IList<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person p)
        {
            this.members.Add(p);
        }

        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(x => x.age).FirstOrDefault();
        }

    }
}
