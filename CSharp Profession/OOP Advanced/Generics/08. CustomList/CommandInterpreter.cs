
namespace _08.CustomList
{
    using System;
   

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
                    this.list.Remove(int.Parse(agruments[1]));
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
                    foreach (var R in this.list)
                    {
                        Console.WriteLine(R);
                    }
                }
                    break;
                case "Min":
                    Console.WriteLine(this.list.Min());
                    break;
                case "Sort": this.list.Sort();
                    break;
                default: throw new ArgumentException(agruments[0]);

            }
        }
    }
}
