using System;

    class ExamWorkHours
    {
        static void Main(string[] args)
        {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        double percents = p * 0.01;
        double workH = d - (d * 0.1);
        workH = workH * 12;
        workH = workH * percents;
        int roundedWorkH = (int)workH;
        if (h <= roundedWorkH)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(roundedWorkH-h);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine(roundedWorkH-h);
        }
    }
    }

