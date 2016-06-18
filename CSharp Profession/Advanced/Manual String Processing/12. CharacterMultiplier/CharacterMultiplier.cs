namespace _12.CharacterMultiplier
{
    using System;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            string str1 = input[0];
            string str2 = input[1];
            int length = 0;
            long sum = 0;
            if (str1.Length > str2.Length)
            {
                length = str2.Length;
            }
            else
            {
                length = str1.Length;
            }

            for (int i = 0; i < length; i++)
            {
                int product = str1[i]*str2[i];
                sum += product;
            }

            for (int i = length; i < str1.Length; i++)
            {
                sum += str1[i];
            }
            for (int i = length; i < str2.Length; i++)
            {
                sum += str2[i];
            }
            Console.WriteLine(sum);
        }
    }
}
