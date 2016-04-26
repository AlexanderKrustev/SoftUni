using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(new []{' '}).Select(long.Parse).ToArray();

            String command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                string[] commands = command.Split(new[] {' '});
                switch (commands[0])
                {
                    case "swap":
                    {
                        int index1 = int.Parse(commands[1]);
                        int index2 = int.Parse(commands[2]);
                        long temp = array[index1];
                        array[index1] = array[index2];
                        array[index2] = temp;

                    }
                        break;
                    case "multiply":
                    {
                        int index1 = int.Parse(commands[1]);
                        int index2 = int.Parse(commands[2]);
                        array[index1] *= array[index2];
                    }
                        break;
                    case "decrease":
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] -= 1;
                        }

                    }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
