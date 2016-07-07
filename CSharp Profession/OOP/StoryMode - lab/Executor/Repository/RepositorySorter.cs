namespace Executor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public  class RepositorySorter
    {
        public  void OrderAndTake(Dictionary<string, double> stundentsMarks,
            string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();
            if (comparison == "ascending")
            {    
                this.PrintStudents(stundentsMarks.OrderBy(x => x.Value)
                                        .Take(studentsToTake)
                                        .ToDictionary(pair => pair.Key, pair => pair.Value)); 
            }
            else if (comparison == "descending")
            {  
                this.PrintStudents(stundentsMarks.OrderByDescending(x => x.Value)
                                        .Take(studentsToTake)
                                        .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else
            {                               
                throw new ArgumentException(ExceptionMessages.InvalidComparisonQuery);
            }
        }

        private  void PrintStudents(Dictionary<string, double> studentsSorted)
        {
            foreach (KeyValuePair<string, double> keyValuePair in studentsSorted)
            {
                OutputWriter.PrintStudent(keyValuePair);
            }
        }
    }
}
