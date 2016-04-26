using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class JoinLists
    {
        static void Main()
        {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string[] input1Arr = input1.Split(' ');
        string[] input2Arr = input2.Split(' ');
        List<int> numbers = new List<int>();
        for (int x = 0; x< input1Arr.Length; x++)
        {
            numbers.Add(int.Parse(input1Arr[x]));
        }
        for(int y=0; y < input2Arr.Length; y++)
        {
            
            int temp = int.Parse(input2Arr[y]);
            if (!numbers.Contains(temp))
            {
                numbers.Add(temp);
            }
        }
        numbers.Sort();
        foreach(int n in numbers)
        {
            Console.Write("{0} ",n);
        }
        Console.WriteLine();
    }
    }

