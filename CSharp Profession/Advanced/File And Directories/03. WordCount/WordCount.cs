namespace _03.WordCount
{
    using System.Collections.Generic;
    using System.IO;

    public class WordCount
    {
        public static void Main()
        {
            string[] allLines = File.ReadAllLines(@"C:\Lab\Streams Tests\04_WordCount\text2.txt");
            string[] words = File.ReadAllLines(@"C:\Lab\Streams Tests\04_WordCount\words2.txt");
            SortedDictionary<string, int> count=new SortedDictionary<string, int>();
            foreach (string row in words)
            {
                string[] w1 = row.Split(new []{'.'  , ',' , '(',')','!','-'});
                foreach (var word in w1)
                {
                    if (count.ContainsKey(word))
                    {
                        break;
                    }
                    count.Add(word, 0);
                }
               
            }

            foreach (string lines in allLines)
            {
                string[] words1 = lines.Split(' ');

                foreach (string str in words1)
                {
                    if (count.ContainsKey(str))
                    {
                        count[str]++;
                    }
                }
            }
            StreamWriter wr=new StreamWriter(@"C:\Lab\Streams Tests\04_WordCount\02_WordCountOut_our.txt");

            foreach (var kvp in count)
            {
                wr.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
            wr.Close();
        }
    }
}
