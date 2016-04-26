using System;


 class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
        string bin = Console.ReadLine();
        long result = 0;
        string temp = "";
        int power = 0;
        for (int i = bin.Length-1; i >= 0; i--)
        {

            temp = temp + bin[i];
            result += long.Parse(temp) * (long)Math.Pow(2, power);
            temp = "";
            power++;
        }
        Console.WriteLine(result);
        }
    }

