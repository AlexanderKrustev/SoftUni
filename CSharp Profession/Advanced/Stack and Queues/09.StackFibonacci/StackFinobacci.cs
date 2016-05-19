using System;
using System.Collections.Generic;

public class StackFinobacci
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Stack<long> fib=new Stack<long>();
        
        fib.Push(1);
        fib.Push(1);
        for (int i = 2; i < n; i++)
        {
            
        
            long f1 = fib.Pop();
            long f2 = fib.Peek();
            fib.Push(f1);
            fib.Push(f1+f2);
            //Console.WriteLine(fib.Peek());
        }

        
        if (n == 0 || n == 1)
        {
            Console.WriteLine("1");
        }
        else
        {
          Console.WriteLine(fib.Peek());
        }
    }
}

