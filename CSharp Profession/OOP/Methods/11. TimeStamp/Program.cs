namespace _11.TimeStamp
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            TimeStamp timeStamp=new TimeStamp();

            while (!input.Equals("End"))
            {
                string[] arguments = input.Split(' ');

                switch (arguments[0])
                {
                    case "Add": timeStamp.Add(arguments[1]);break;
                    case "Set": timeStamp.Set(arguments[2], int.Parse(arguments[1]));
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(timeStamp);


        }
    }
}
