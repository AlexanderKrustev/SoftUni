using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


    class PetarsGame
    {
        static void Main()
        {
        BigInteger startNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger endNumber = BigInteger.Parse(Console.ReadLine());
        string replacementString = Console.ReadLine();
        BigInteger sum = 0;
        for(BigInteger x = startNumber; x < endNumber; x++)
        {
            if (x % 5 == 0)
            {
                sum += x;
            }
            else
            {
                sum += (x % 5);
            }
        }
        string forReplace = sum.ToString();
        string result = "";
        if (sum % 2 == 0)
        {
            for(int z = 0; z < forReplace.Length; z++)
            {
                if (forReplace[0] == forReplace[z])
                {
                    result = result + replacementString;
                }
                else
                {
                    result = result + forReplace[z];
                }
                   
            }
        }
        else
        {
            for (int z = 0; z < forReplace.Length; z++)
            {
                if (forReplace[forReplace.Length-1] == forReplace[z])
                {
                    result = result + replacementString;
                }
                else
                {
                    result = result + forReplace[z];
                }

            }
        }
        Console.WriteLine(result);
    }
    }

