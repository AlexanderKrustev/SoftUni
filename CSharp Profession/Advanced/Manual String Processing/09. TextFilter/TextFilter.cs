namespace _09.TextFilter
{
    using System;
    using System.Text;

    public class Program
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new[] {',',' '}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            StringBuilder sb=new StringBuilder();
            int lastJ = 0;
            
            for (int i = 0; i < bannedWords.Length; i++)
            {
                
                string currentBannedWord = bannedWords[i];
                if (text.Equals(bannedWords[i]))
                {
                    sb.Append(new string('*', currentBannedWord.Length));
                    text = sb.ToString();
                    break;
                }
                for (int j = 0; j < text.Length -currentBannedWord.Length+1; j++)
                {
                    string temp = text.Substring(j, bannedWords[i].Length);
                    if (text.Substring(j, bannedWords[i].Length).Equals(bannedWords[i]))
                    {
                        sb.Append(new string('*', currentBannedWord.Length));
                        j = j + currentBannedWord.Length-1;
                    }
                    else
                    {
                        sb.Append(text[j]);
                    }

                    lastJ = j;
                }

                if (lastJ < text.Length)
                {
                    sb.Append(text.Substring(lastJ+1, text.Length - lastJ-1));
                    lastJ = 0;
                }
                text = sb.ToString();
                sb.Clear();
            }

            Console.WriteLine(text);
        }
    }
}
