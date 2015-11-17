using System;
 class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;
        do
        {
            Console.WriteLine("Please enter values for min and max, where min<max");
            Console.Write("min= ");
            min = int.Parse(Console.ReadLine());
            Console.Write("max= ");
            max = int.Parse(Console.ReadLine());
        } while (min > max);
        Random randomNumber = new Random();
        for (int i = 0; i < n; i++)
        {
            int rndNumber = randomNumber.Next(min, max+1);
            Console.Write("{0} ", rndNumber);
        }
        Console.WriteLine();
    }
    }

