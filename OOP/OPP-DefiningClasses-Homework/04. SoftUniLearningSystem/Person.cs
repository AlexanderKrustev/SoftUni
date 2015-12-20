using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniLearningSystem
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
                    throw new ArgumentException("First name cannot be empty");
                this.firstName = value;
            }
        }
       private string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Last name cannot be empty");
                this.lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 110)
                    throw new ArgumentException("The age must be in range [1...110]");
                this.age = value;
            }
        }
  
        public Person(string firstname,string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;

        }
        public override string ToString()
        {
            return string.Format("First Name: {0}\nLast Name: {1}\nAge: {2}", this.FirstName, this.LastName, this.Age);
        }

    }
}
