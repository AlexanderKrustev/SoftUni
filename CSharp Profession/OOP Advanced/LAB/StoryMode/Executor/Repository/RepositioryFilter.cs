namespace Executor.Repository
{
    using System;
    using System.Collections.Generic;
    using Executor.Contracts;
    using Executor.Static_data;
    using IO;

    public class RepositioryFilter : IDataFilter
    {
        public void PrintFilteredStudents(Dictionary<string, double> studentsWithMarks, string wantedFilter, int studentsToTake)
        {
            if (wantedFilter == "excellent")
            {
                this.PrintFilteredStudents(studentsWithMarks, x => x >= 5, studentsToTake);
            }
            else if (wantedFilter == "average")
            {
                this.PrintFilteredStudents(studentsWithMarks, x => x < 5 && x >= 3.5, studentsToTake);
            }
            else if (wantedFilter == "poor")
            {
                this.PrintFilteredStudents(studentsWithMarks, x => x < 3.5, studentsToTake);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidStudentsFilter);
            }
        }

        private void PrintFilteredStudents(Dictionary<string, double> studentsWithMarks, Predicate<double> givenFilter, int studentsToTake)
        {
            int counterForPrinted = 0;
            foreach (var studentMark in studentsWithMarks)
            {
                if (counterForPrinted == studentsToTake)
                {
                    break;
                }

                if (givenFilter(studentMark.Value))
                {
                    OutputWriter.WriteMessageOnNewLine(string.Format($"{studentMark.Key} - {studentMark.Value}"));
                    counterForPrinted++;
                }
            }
        }
    }
}
