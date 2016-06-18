namespace _05.ConvertFromBaseNBase10
{
    using System;
    using System.Numerics;

    public class ConvertFromBaseNBase10
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            string number = input[1];
            BigInteger numberDec = new BigInteger();
            int power = 0;
            for (int i = number.Length-1; i >=0; i--)
            {
                int temp1 = int.Parse(number[i].ToString());
                
                numberDec += temp1*BigInteger.Pow(n, power++);
                
            }
            Console.WriteLine(numberDec);
        }
    }
}
