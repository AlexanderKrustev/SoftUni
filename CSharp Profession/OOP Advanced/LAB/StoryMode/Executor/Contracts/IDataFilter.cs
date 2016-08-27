namespace Executor.Contracts
{
    using System.Collections.Generic;

    public interface IDataFilter
    {
        void PrintFilteredStudents(Dictionary<string, double> studentsWithMarks, string wantedFilter, int studentsToTake);
    }
}
