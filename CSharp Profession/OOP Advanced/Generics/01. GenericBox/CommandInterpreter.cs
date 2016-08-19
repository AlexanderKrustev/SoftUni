
namespace _01.GenericBox
{
    using System;
    using _08.CustomList;

    public class CommandInterpreter
    {
        private ICustomList<string> list;

        public CommandInterpreter(ICustomList<string> list)
        {
            this.list = list;
        }
        public void ParseCommand(string input)
        {
            string[] agruments = input.Split();

            switch (agruments[0])
            {
                case "Add": this.list.Add(agruments[1]);
                    break;
                case "Remove":
                    Console.WriteLine(this.list.Remove(int.Parse(agruments[1])));
                    break;
                case "Contains":
                    Console.WriteLine(this.list.Contains(agruments[1]));
                    break;
                case "Swap": this.list.Swap(int.Parse(agruments[1]), int.Parse(agruments[2]));
                    break;
                case "Greater":
                    Console.WriteLine(this.list.CountGreaterThan(agruments[1]));
                    break;
                case "Max":
                    Console.WriteLine(this.list.Max());
                    break;
                case "Print":
                {
                    foreach (var el in this.list)
                    {
                        
                    }
                }
            }
        }
    }
}
