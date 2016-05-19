using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateSequence_with_Queue
{
    class CalculateSequenceWithQueue
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long s = n;
            Queue<long> queue = new Queue<long>();
            queue.Enqueue(s);
            Console.Write(s+" ");
            for (int i = 0; i < 16; i++)
            {
                s = queue.Dequeue();
                queue.Enqueue(s+1);
                Console.Write("{0} ",s+1);
                queue.Enqueue((2*s)+1);
                Console.Write("{0} ", (2 * s) + 1);
                queue.Enqueue(s+2);
                Console.Write("{0} ", s + 2);
              
            }
            s = queue.Dequeue();
            while (queue.Count > 1)
            {
                
                queue.Dequeue();
            }
            Console.WriteLine("{0} ", s +1);


        }
    }
}
