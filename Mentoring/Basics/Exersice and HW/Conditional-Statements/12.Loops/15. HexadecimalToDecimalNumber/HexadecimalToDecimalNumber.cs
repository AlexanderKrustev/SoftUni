using System;


    class HexadecimalToDecimalNumber
    {
        static int SymbolToInt(string s)
    {
        switch (s)
        {
            case "1": return 1; 
            case "2": return 2; 
            case "3": return 3; 
            case "4": return 4; 
            case "5": return 5; 
            case "6": return 6; 
            case "7": return 7; 
            case "8": return 8; 
            case "9": return 9; 
            case "A": return 10; 
            case "B": return 11; 
            case "C": return 12; 
            case "D": return 13; 
            case "E": return 14; 
            case "F": return 15;
            default: return 0; break;
          
        }
        
    }
        static void Main(string[] args)
        {
        string hex = Console.ReadLine();
        long result = 0;
        string temp = "";
        int power = 0;
        for (int i = hex.Length - 1; i >= 0; i--)
        {

            temp = temp + hex[i];
            result += SymbolToInt(temp) * (long)Math.Pow(16, power);
            temp = "";
            power++;
        }
        Console.WriteLine(result);
    }
}
    

