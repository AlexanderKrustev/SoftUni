using System;
using System.Collections.Generic;

class Program
    {   static string DecimalToHex(long n)
    {

        switch (n)
        {
            case 0: return "0";
            case 1: return "1";
            case 2: return "2";
            case 3: return "3";
            case 4: return "4";
            case 5: return "5";
            case 6: return "6";
            case 7: return "7";
            case 8: return "8";
            case 9: return "9";
            case 10: return "A";
            case 11: return "B";
            case 12: return "C";
            case 13: return "D";
            case 14: return "E";
            case 15: return "F";
            default: return "q"; 
        }

            
        }
        static void Main()
        {
        long n = long.Parse(Console.ReadLine());
        string result = "";
        List<long> bin = new List<long>();
        while (n > 0)
        {
            bin.Add((long)n % 16);
            n /= 16;
        }
        for (int x = bin.Count-1; x >= 0; x--)
        {
            Console.WriteLine(bin[x]+"-->"+DecimalToHex(bin[x]));
            result += DecimalToHex(bin[x]);
        }
        Console.WriteLine(result);
    }
}
    

