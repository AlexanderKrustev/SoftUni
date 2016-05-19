using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BalancedParentheses
{
    using System.Globalization;

    public class BalancedParentheses
    {
        public static void Main(string[] args)
        {
            string seq = Console.ReadLine();
            bool isBalanced = true;

            if (seq.Length% 2 != 0)
            {
                isBalanced = false;
            }

            Stack<char> leftSide = new Stack<char>();
            Queue<char> rightSide = new Queue<char>();

            for (int i = 0; i < seq.Length; i++)
            {
               
                if (seq[i] == '[' || seq[i] == '(' || seq[i] == '{')
                    {
                        leftSide.Push(seq[i]);

                    }
                    else if (seq[i] == ']' || seq[i] == ')' || seq[i] == '}')
                    {
                        rightSide.Enqueue(seq[i]);

                    }
                    else if (seq[i] == ' ')
                    {

                    }
                

            }
            if (leftSide.Count() == 0 || rightSide.Count() == 0)
            {
                isBalanced = false;
            }
           
                while (leftSide.Count > 0)
                {
                    switch (leftSide.Pop())
                    {
                        case '{':
                        {
                            if (rightSide.Dequeue() != '}')
                            {
                                isBalanced = false;
                            }
                        }
                            break;
                        case '(':
                        {
                            if (rightSide.Dequeue() != ')')
                            {
                                isBalanced = false;
                            }
                        }
                            break;
                        case '[':
                        {
                            if (rightSide.Dequeue() != ']')
                            {
                                isBalanced = false;
                            }
                        }
                            break;
                        case ' ':
                        {
                            if (rightSide.Dequeue() != ' ')
                            {
                                isBalanced = false;
                            }
                        }
                            break;
                    }
                }
            

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
