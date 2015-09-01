using System;

    class ComparingFloats
    {
        static void Main(string[] args)
        {
        double[] numbersA = new double[6] { 5.3 , 5.00000001 , 5.00000005 , -0.0000007 , -4.999999 , 4.999999 };
        double[] numbersB = new double[6] {6.01 , 5.00000003 , 5.00000001 ,0.00000007 , -4.999998 , 4.999998 };
        double eps = 0.000001;
        for(int x = 0; x < 6; x++)
        {
            Console.Write("numberA= {0} , numberB = {1}    ", numbersA[x], numbersB[x]);
            if ((Math.Abs(numbersA[x] - numbersB[x])) < 0.000001)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        }
    }

