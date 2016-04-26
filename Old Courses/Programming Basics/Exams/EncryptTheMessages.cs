using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class EncryptTheMessages
    {
      public static string Crypter(char s)
    {   
        switch(s){
            case 'A': return "N"; 
            case 'a': return "n"; 
            case 'B': return "O"; 
            case 'b': return "o"; 
            case 'C': return "P"; 
            case 'c': return "p"; 
            case 'D': return "Q"; 
            case 'd': return "q"; 
            case 'E': return "R"; 
            case 'e': return "r"; 
            case 'F': return "S"; 
            case 'f': return "s"; 
            case 'G': return "T"; 
            case 'g': return "t"; 
            case 'H': return "U"; 
            case 'h': return "u"; 
            case 'I': return "V"; 
            case 'i': return "v"; 
            case 'J': return "W"; 
            case 'j': return "w"; 
            case 'K': return "X"; 
            case 'k': return "x";
            case 'L': return "Y";
            case 'l': return "y";
            case 'M': return "Z";
            case 'm': return "z";
            case 'N': return "A";
            case 'n': return "a";
            case 'O': return "B";
            case 'o': return "b";
            case 'P': return "C";
            case 'p': return "c";
            case 'Q': return "D";
            case 'q': return "d";
            case 'R': return "E";
            case 'r': return "e";
            case 'S': return "F";
            case 's': return "f";
            case 'T': return "G";
            case 't': return "g";
            case 'U': return "H";
            case 'u': return "h";
            case 'V': return "I";
            case 'v': return "i";
            case 'W': return "J";
            case 'w': return "j";
            case 'X': return "K";
            case 'x': return "k";
            case 'Y': return "l";
            case 'y': return "l";
            case 'Z': return "M";
            case 'z': return "m";
            case ' ': return "+";
            case ',': return "%";
            case '.': return "&";
            case '?': return "#";
            case '!': return "$";
            case '1': return "1";
            case '2': return "2";
            case '3': return "3";
            case '4': return "4";
            case '5': return "5";
            case '6': return "6";
            case '7': return "7";
            case '8': return "8";
            case '9': return "9";
            case '0': return "0";
            default: return ""; 
        }
    }

        static void Main(string[] args)
        {
        List<string> messages = new List<string>();
        List<string> Cryptedmessages = new List<string>();
        bool isFinished = false;
        bool isStarted = false;
        while (!isFinished)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "start")
            {
                isStarted = true;
            }
            if (isStarted)
            {
                if (input.ToLower() != "start" && input.ToLower() != "end" && input!=string.Empty)
                {
                    messages.Add(input);
                }
            }
            if (input.ToLower() == "end")
            {
                isFinished = true;
            }

        }
        
        for(int x = 0; x < messages.Count; x++)
        {
            String result = "";
            String temp = messages[x];
            
            for(int z = messages[x].Length - 1; z >= 0; z--)
            {
                result += Crypter(temp[z]);
            }
            Cryptedmessages.Add(result);
        }
        if (Cryptedmessages.Count != 0)
        {
            Console.WriteLine("Total number of messages: {0}", Cryptedmessages.Count);
        }
        else
        {
            Console.WriteLine("No messages sent.");
        }
        for(int y=0; y < Cryptedmessages.Count; y++)
        {
            Console.WriteLine(Cryptedmessages[y]);
        }
        }
    }

