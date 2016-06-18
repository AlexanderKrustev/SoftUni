namespace _04.ConvertFromBase10ToN
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class ConvertFromBase10ToN
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            StringBuilder result=new StringBuilder();
            Stack<BigInteger> tempResult=new Stack<BigInteger>();
            while (number > 0)
            {
                tempResult.Push(number%n);
                number /= n;
            }
            for (int i = tempResult.Count-1; i >=0; i--)
            {
                result.Append(tempResult.Pop());
            }
            Console.WriteLine(result);
        }
    }
}
