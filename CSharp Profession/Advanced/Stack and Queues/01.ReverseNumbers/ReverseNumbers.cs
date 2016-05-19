using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program that reads N integers from the console and reverses them using a stack.
Use the Stack<int> class from .NET Framework.
Just put the input numbers in the stack and pop them. 
Input:1 2 3 4 5  Output: 5 4 3 2 1
    */

class ReverseNumbers
    {
        static void Main()
        {

            int[] n =Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Stack<int> stk=new Stack<int>();

            for (int i = 0; i < n.Length; i++)
            {
                stk.Push(n[i]);
            }

            while (stk.Count > 0)
            {
                Console.Write(stk.Pop()+" ");
            }

        }
    }

