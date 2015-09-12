using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfElements
    {
        static void Main()
        {
        List<long> numbers = new List<long>();
        string stringNumbers = Console.ReadLine();
        string[] arrayString = stringNumbers.Split(' ');
        foreach(string number in arrayString)
        {
            numbers.Add(int.Parse(number));
        }
        numbers.Sort();
        int length = numbers.Count();
        long maxNumber=numbers[length-1];
        long sum = 0;
        for(int x=0; x < length-1; x++)
        {
            sum += numbers[x];
           
        }
        if (sum == maxNumber)
        {
            Console.WriteLine("Yes, sum={0}",sum);
        }
        else
        {
          
            Console.WriteLine("No, diff={0}",Math.Abs(sum-maxNumber));

        }
        }
    }

