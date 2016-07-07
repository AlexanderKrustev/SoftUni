using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DateModifier
{
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            DateModifier modifier=new DateModifier();
            Console.WriteLine(modifier.CalculateDaysBetweenTwoDates(date1,date2));
            var s = 0;
        }
    }

    public class DateModifier
    {
        public DateTime date1;
        public DateTime date2;
        

        public double CalculateDaysBetweenTwoDates(string date1, string date2)
        {
            int[] d1 = date1.Split(' ').Select(int.Parse).ToArray();
            int[] d2 = date2.Split(' ').Select(int.Parse).ToArray();
            this.date1 = DateTime.ParseExact(date1, "yyyy MM dd", CultureInfo.InvariantCulture);
            this.date2 = DateTime.ParseExact(date2, "yyyy MM dd", CultureInfo.InvariantCulture);
            TimeSpan t=new TimeSpan();
            
                t = this.date1.AddDays(1) - this.date2;
            

           
            return Math.Abs(t.TotalDays);// Math.Abs((this.date1. - this.date2.Day));
            
        }
    }
}
