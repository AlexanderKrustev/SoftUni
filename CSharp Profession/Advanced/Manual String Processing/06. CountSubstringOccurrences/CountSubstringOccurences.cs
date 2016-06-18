namespace _06.CountSubstringOccurrences
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int counter = 0;
            for (int i = 0; i <= input.Length-pattern.Length; i++)
            {
                if (pattern.Equals(input.Substring(i, pattern.Length)))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
