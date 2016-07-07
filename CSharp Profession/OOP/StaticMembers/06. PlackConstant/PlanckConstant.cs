namespace _06.PlackConstant
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine(Calculation.Cals());
        }
    }

    public class Calculation
    {
        public const double plank = 6.62606896e-34;
        public const double pi = 3.14159;

        public static double Cals()
        {
            return plank/(2*pi);
        }
    }
}
