namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;

    public class Palindromes
    {
        public static void Main()
        {
            string[] text = Console.ReadLine()
                .Split(new[] {' ', ',', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> palindromes=new SortedSet<string>();
            foreach (var word in text)
            {
                if (isPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine("["+string.Join(", ", palindromes)+"]");
        }

        public static bool isPalindrome(string word)
        {
            string leftSide = word.Substring(0, word.Length/2);
            string rightSide = "";
            string rightSideR = "";
            if (word.Length%2 != 0)
            {
                 rightSide = word.Substring((word.Length / 2)+1, word.Length / 2);
            }
            else
            {
                rightSide = word.Substring(word.Length / 2, word.Length / 2);
            }

            for (int i = rightSide.Length-1; i>=0; i--)
            {
                rightSideR += rightSide[i];
            }
            if (leftSide.Equals(rightSideR))
            {
                return true;
            }

            return false;
        }
    }
}
