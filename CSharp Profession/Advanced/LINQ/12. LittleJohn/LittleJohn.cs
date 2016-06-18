namespace _12.LittleJohn
{
    using System;
    using System.Linq;

    class LittleJohn
    {
        static void Main(string[] args)
        {
            string patternLarge = ">>>----->>";
            string patternMedium = ">>----->";
            string patternSmall = ">----->";
            long countOfLarge = 0;
            long countOfMedium = 0;
            long countOfSmall = 0;
            
            string input = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {

                countOfLarge += CountStringOccurrences(input, patternLarge);
                input = input.Replace(patternLarge, "");
                countOfMedium += CountStringOccurrences(input, patternMedium);
                input = input.Replace(patternMedium, "");
                countOfSmall += CountStringOccurrences(input, patternSmall);
                input = Console.ReadLine();
            }
            string tempResult = "" + countOfSmall + countOfMedium + countOfLarge;
            string Ans = Convert.ToString(int.Parse(tempResult), 2);
            tempResult = ReverseString(Ans);
            Ans += tempResult;
            Console.WriteLine(Convert.ToInt32(Ans, 2));
            var a = 0;
        }

        public static int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
