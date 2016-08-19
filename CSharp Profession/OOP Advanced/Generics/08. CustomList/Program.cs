namespace _08.CustomList
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input=Console.ReadLine();
            ICustomList<string> list=new MyList<string>();
            CommandInterpreter command=new CommandInterpreter(list);
            while (!input.Equals("END"))
            {
                command.ParseCommand(input);

                input = Console.ReadLine();
            }
        }
    }
}
