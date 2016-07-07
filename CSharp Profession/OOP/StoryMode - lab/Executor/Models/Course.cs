namespace Executor.Models
{
    using System;
    using System.Collections.Generic;
    using Exceptions;

    public class Course
    {
        public const int NumberOfTasksOnExam = 5;
        public const int MaxScoreOnExamTask = 100;
        private string name;
        private Dictionary<string, Student> studentByName;

        public Course(string name)
        {
            this.Name = name;
            this.studentByName = new Dictionary<string, Student>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }
                this.name = value;
            }
        }

        public IReadOnlyDictionary<string, Student> StudenByName => this.studentByName;
       

        public void EnrollStudent(Student student)
        {
            if (this.StudenByName.ContainsKey(student.UserName))
            {
              throw  new DuplicateEntryInStructureException(student.UserName,this.Name);
            
            }

            this.studentByName.Add(student.UserName,student);
        }
    }
}
