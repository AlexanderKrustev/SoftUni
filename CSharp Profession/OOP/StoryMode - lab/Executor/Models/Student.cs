﻿namespace Executor.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Exceptions;

    public class Student
    {
        private string userName;
        private Dictionary<string, Course> enrolledCourses;
        private Dictionary<string, double> marksByCourseName;

        public Student(string userName)
        {
            this.UserName = userName;
            this.enrolledCourses = new Dictionary<string, Course>();
            this.marksByCourseName = new Dictionary<string, double>();
        }

        public string UserName
        {
            get
            {
                return this.userName;
                
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }
                this.userName = value;
            }
        }

        public IReadOnlyDictionary<string, Course> EnrolledCourses => this.enrolledCourses;

        public IReadOnlyDictionary<string, double> MarksByCourseName => this.marksByCourseName;
     

        public void EnrollInCourse(Course course)
        {
            if (this.EnrolledCourses.ContainsKey(course.Name))
            {
              throw new DuplicateEntryInStructureException(this.userName, course.Name);
                  
            }

            this.enrolledCourses.Add(course.Name, course);
        }

        public void SetMarkOnCourse(string courseName, params int[] scores)
        {
            if (!this.enrolledCourses.ContainsKey(courseName))
            {
                throw new ArgumentException(ExceptionMessages.NotEnrolledInCourse);
          
            }
            if (scores.Length > Course.NumberOfTasksOnExam)
            {
                throw new ArgumentException(ExceptionMessages.InvalidNumberOfScores);
                
            }

            if (this.MarksByCourseName.ContainsKey(courseName))
            {
                throw new Exceptions.KeyNotFoundException();
            }
                this.marksByCourseName.Add(courseName, CalculateMark(scores));
            

        }

        private double CalculateMark(int[] scores)
        {
            double percentageOfSolvedExam = scores.Sum()/(double) (Course.NumberOfTasksOnExam*Course.MaxScoreOnExamTask);
            double mark = percentageOfSolvedExam*4 + 2;
            return mark;
        }
    }
}