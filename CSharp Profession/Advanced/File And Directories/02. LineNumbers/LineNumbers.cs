namespace _02.LineNumbers
{
    using System.Collections.Generic;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            string[] allLines = File.ReadAllLines(@"C:\Lab\Streams Tests\03_LineNumbers\01_LinesIn.txt");
            List<string> result = new List<string>();
           for (int i = 0; i < allLines.Length; i++)
            {

                result.Add(i + 1 + ". " + allLines[i]);
            }

            File.WriteAllLines(@"C:\Lab\Streams Tests\03_LineNumbers\01_LinesOut_our.txt", result);
        }
    }
}



