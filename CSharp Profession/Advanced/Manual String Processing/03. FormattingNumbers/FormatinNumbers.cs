namespace _03.FormattingNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new []{' ','\t','\n','\r'}, StringSplitOptions.RemoveEmptyEntries);
            string hexdecimalString = Convert.ToString(long.Parse(input[0]), 16).ToUpper().PadRight(10);
            string binary = Convert.ToString(long.Parse(input[0]), 2).PadLeft(10,'0');
            if (binary.Length > 10)
            {
                binary = binary.Substring(0,10);

            }
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);
            string bS = string.Format("{0:f2}", b);
            string cS = string.Format("{0:f3}", c);
            Console.WriteLine("|{0}|{1}|{2}|{3}|", 
                hexdecimalString,
                binary,
                bS.PadLeft(10), 
                cS.PadRight(10));
            Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:0.00}|{3,-10:0.000}|", long.Parse(input[0]), binary, b, c);

        }
    }
}
