using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniLearningSystem
{
    public class Student : Person
    {
        private string sn;
        private double ag;
        
        public string SudentNumber
        { get { return this.sn; }
          set
            {
                if (value == null)
                    throw new ArgumentException("Student number cannot be empty.");
                this.sn = value;
            }
        }

        public double AvarageGrade
        {
            get { return this.ag; }
            set
            {
                if (value <2 || value>6 )
                    throw new ArgumentException("Student number cannot be empty.");
                this.ag = value;
            }
        }

        
        public Student(string firstName, string lastName, int age, string sn, double ag)
    : base(firstName, lastName, age)
        {
            this.SudentNumber = sn;
            this.AvarageGrade = ag;
        }


    }
}
