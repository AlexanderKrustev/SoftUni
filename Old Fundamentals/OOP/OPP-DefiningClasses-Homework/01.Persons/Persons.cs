using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Persons
    {
        public string name;
        public string mail;
        public int age;


        public Persons(string name, int age, string mail)
        {
            this.Name = name;
            this.Age = age;
            this.Mail = mail;
        }
        public Persons(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != null && value!=String.Empty)
                {
                    this.name = value;

                }
                else
                {
                    throw new Exception("The name cannot be empty ");
                }
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Invalid Age");
                }
            }
        }
        public string Mail
        {
            get { return this.mail; }
            set
            {
                if (value.Contains('@') || value==null)
                {
                    this.mail = value;

                }
                else
                {
                    throw new Exception("Not Correct Mail");
                }
            }
        }
        public static void ToString(Persons person)
        {
            Console.WriteLine("Name: {0}",person.Name);
            Console.WriteLine("Age: {0}",person.Age);
            Console.WriteLine("Mail: {0}",person.Mail);
        }

    }
}
