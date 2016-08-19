namespace _01.GenericBox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   
    class Startup
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            List<GenericBox<double>> mylist=new List<GenericBox<double>>();
            for (int i = 0; i < rows; i++)
            {
                mylist.Add(new GenericBox<double>(double.Parse(Console.ReadLine())));
            }

            double other = double.Parse(Console.ReadLine());
            var counter = Counter(mylist, other);

            Console.WriteLine(counter);
        }

        private static int Counter(List<GenericBox<double>> mylist, double other)
        {
            int counter = 0;
            foreach (var gb in mylist)
            {
                if (gb.CompareTo(other) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static List<GenericBox<int>> Swap(int index1, int index2, List<GenericBox<int>> mylist)
        {
            List<GenericBox<int>> newlist = mylist;
            var box1 = mylist[index1];
            var box2 = mylist[index2];
            newlist[index2] = box1;
            newlist[index1] = box2;

            return newlist;

        }
    }
}
