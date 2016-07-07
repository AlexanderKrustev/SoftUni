namespace _01.Students
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            StudentGroup group=new StudentGroup();
            while (! input.Equals("End"))
            {
                group.Add(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(StudentGroup.uniqueCount);
        }
    }

    public class Student
    {
        public string name;
        public static int count = 0;


        public Student(string name)
        {
            this.name = name;
            count++;
        }
    }

    public class StudentGroup
    {
        public HashSet<string> st;
        public static int uniqueCount=0;

        public StudentGroup()
        {
            this.st=new HashSet<string>();
        }

        public void Add(string student)
        {
            if (!this.st.Contains(student))
            {
                this.st.Add(student);
                uniqueCount++;
            }
        }
    }
}
