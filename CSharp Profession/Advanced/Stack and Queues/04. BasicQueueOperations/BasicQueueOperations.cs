using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] arguments = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] itemsForEnq = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < arguments[0]; i++)
            {
                queue.Enqueue(itemsForEnq[i]);
            }
            for (int i = 0; i < arguments[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(arguments[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }

        }
    }
}

