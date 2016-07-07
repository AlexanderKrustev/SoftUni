namespace _05.FibonacciNumbers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Security;

    public class Program
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            Fibonaci f=new Fibonaci(stop);
            Console.WriteLine(string.Join(", ",f.PrintList(start, stop)));
        }
    }

    public class Fibonaci
    {
        public List<long> row;

        public Fibonaci(int end)
        {
            Init(end);
        }

        public void Init(int end)
        {
            this.row=new List<long>();

            row.Add(0);
            row.Add(1);
            row.Add(1);

            for (int i = 3; i < end; i++)
            {
                row.Add(row[i-1]+row[i-2]);
            }
        }

        public List<long> PrintList(int start, int stop)
        {
            List<long> result=new List<long>();

            for (int i = start; i < stop; i++)
            {
                result.Add(row[i]);
            }
            return result;
        }
    }
}
