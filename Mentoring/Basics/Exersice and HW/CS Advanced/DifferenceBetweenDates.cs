using System;

    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        DateTime date1 = DateTime.Parse(input1);
        DateTime date2 = DateTime.Parse(input2);
        Console.WriteLine((date2.Date-date1.Date).TotalDays);
    }
    }

