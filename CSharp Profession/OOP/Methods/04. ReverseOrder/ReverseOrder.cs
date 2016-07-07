namespace _04.ReverseOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public  class Program
    {
        static void Main()
        {
            DecimalNumber n=new DecimalNumber();
            string input = Console.ReadLine();
            Console.WriteLine(n.Reverse(input));
        }
    }

    public class DecimalNumber
    {
        

        public decimal Reverse(string temp)
        {
            StringBuilder sb=new StringBuilder();
            for (int i = temp.Length-1; i >=0; i--)
            {
                sb.Append(temp[i]);
            }

            return decimal.Parse(sb.ToString());
        }

    }
}
