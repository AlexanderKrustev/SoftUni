namespace _01.OddLines
{
    using System.Collections.Generic;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            string[] allLines = File.ReadAllLines(@"C:\Lab\Streams Tests\02_OddLines\03_OddLinesIn.txt");
            List<string> result=new List<string>();
            int counter = 0;
            for (int i = 0; i < allLines.Length; i++)
            {
                if (i%2 == 1)
                {
                    result.Add(allLines[i]);
                }
            }

            
            File.WriteAllLines(@"C:\Lab\Streams Tests\02_OddLines\03_OddLinesOut_Our.txt",result);
        }
    }
}
