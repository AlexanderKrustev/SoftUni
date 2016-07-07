namespace _07.BasicMath
{
    using System;


    public class Program
    {
        public static void Main()
        {

            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                string[] p = input.Split(' ');
                double num1 = double.Parse(p[1]);
                double num2 = double.Parse(p[2]);
                switch (p[0])
                {
                    case "Sum":
                        Console.WriteLine("{0:f2}", MathUtils.Sum(num1, num2));
                        break;
                    case "Subtract":
                        Console.WriteLine("{0:f2}", MathUtils.Substract(num1, num2));
                        break;
                    case "Divide":
                        Console.WriteLine("{0:f2}", MathUtils.Devide(num1, num2));
                        break;
                    case "Percentage":
                        Console.WriteLine("{0:f2}", MathUtils.Percentage(num1, num2));
                        break;
                    case "Multiply":
                        Console.WriteLine("{0:f2}", MathUtils.Multiply(num1, num2));
                        break;

                }

                input = Console.ReadLine();
            }
        }
    }

    public static class MathUtils
    {
        public static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1*num2;
        }

        public static double Percentage(double num1, double num2)
        {
            return num1*(num2/100);
        }

        public static double Devide(double num1, double num2)
        {
            return num1/num2 ;
        }

        public static double Substract(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
