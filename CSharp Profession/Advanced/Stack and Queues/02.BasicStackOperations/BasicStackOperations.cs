using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Play around with a stack. You will be given an integer N representing the amount of elements to push onto the stack, an integer S representing the amount of elements to pop from the stack and finally an integer X, an element that you should check whether is present in the stack. If it is print true on the console, if it’s not print the smallest element currently present in the stack.
Input Format:
On the first line you will be given N, S and X separated by a single space. On the next line you will be given N amount of integers.
Output Format:
On a single line print either true if X is present in the stack otherwise print smallest element in the stack. If the stack is empty print 0.

    input        output
5 2 13
1 13 45 32 4	true
	 
4 1 666
420 69 13 666	13

3 3 90
90 90 90 	     0
*/

namespace _02.BasicStackOperations
{
    using System.Globalization;
    using System.Runtime.InteropServices;

    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] arguments = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] itemsToPush = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();
            Stack<int> stk=new Stack<int>();

            for (int i = 0; i < arguments[0]; i++)
            {
                stk.Push(itemsToPush[i]);
            }
            for (int i = 0; i < arguments[1]; i++)
            {
                stk.Pop();
            }

            if (stk.Contains(arguments[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stk.Count > 0)
                {
                    Console.WriteLine(stk.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
