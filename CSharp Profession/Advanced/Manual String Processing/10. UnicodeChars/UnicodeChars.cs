using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb=new StringBuilder();
            foreach (var ch in input)
            {
                sb.Append(GetEscapeSequence(ch));
            }
            Console.WriteLine(sb);
        }
        public static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4").ToLower();
        }
    }
}
