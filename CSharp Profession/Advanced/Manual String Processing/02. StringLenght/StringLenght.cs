namespace _02.StringLenght
{
    using System;
    using System.Text;

    public class StringLenght
    {
       public static void Main()
       {
           string input = Console.ReadLine();
        StringBuilder sb=new StringBuilder();
           if (input.Length >= 20)
           {
               for (int i = 0; i < 20; i++)
               {
                   sb.Append(input[i]);
               }
           }
           else
           {
               for (int i = 0; i < input.Length; i++)
               {
                   sb.Append(input[i]);
               }
               for (int i = 0; i < 20-input.Length; i++)
               {
                   sb.Append("*");
               }
           }
           Console.WriteLine(sb);
       }
    }
}
