namespace _13.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            string word1 = input[0];
            string word2 = input[1];
            if (GetStatus(word1, word2))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
           

        }

        public static bool GetStatus(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word2) || string.IsNullOrEmpty(word1))
            {
                return false;
            }
            Dictionary<char, char> firstDirection = new Dictionary<char, char>();
            Dictionary<char, char> secondDirection = new Dictionary<char, char>();
            int length = 0;
            if (word1.Length > word2.Length)
            {
                length = word2.Length;
            }
            else
            {
                length = word1.Length;
            }

            for (int i = 0; i < length; i++)
            {
                if (firstDirection.ContainsKey(word1[i]))
                {
                    if (firstDirection[word1[i]] != word2[i])
                    {
                        return false;
                    }
                }
                else
                {
                    firstDirection.Add(word1[i],word2[i]);
                    secondDirection.Add(word2[i],word1[i]);
                }
               
            }

            for (int i = length; i < word2.Length; i++)
            {
                if (!secondDirection.ContainsKey(word2[i]))
                {
                    return false;
                }
            }
            for (int i = length; i < word1.Length; i++)
            {
                if (!firstDirection.ContainsKey(word1[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
