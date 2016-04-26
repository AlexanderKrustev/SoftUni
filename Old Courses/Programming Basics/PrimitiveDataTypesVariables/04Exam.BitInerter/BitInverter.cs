using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main()
        {
        List<int> numbersDEC = new List<int>();
        List<int> numbersBIN = new List<int>();
        List<int> numbersBINinverted = new List<int>();
        int countNumbers = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        for(int x=countNumbers; x>0; x--)
        {
            numbersDEC.Add(int.Parse(Console.ReadLine()));
        }
        for(int x=numbersDEC.Count()-1; x>=0;x--)
        {
            int tempNumber = numbersDEC[x];

            int isEight = 0;
            while (tempNumber > 0)
            {
                
                numbersBIN.Add(tempNumber % 2);
                tempNumber = tempNumber / 2;
                isEight++;
            }
            while (isEight != 8) { 
                numbersBIN.Add(0);
                isEight++;
            }
            if(isEight==8)
            {
                isEight = 0;
            }
        }
        
        int newBinN = 0;
        for (int x = numbersBIN.Count()-1; x >=0; x--)

        {
            newBinN++;
          // Console.Write(numbersBIN[x]);
            if (newBinN == 8)
            {
             //   Console.Write(" ");
                newBinN = 0;
            }
            
        }


     //   Console.WriteLine();
        int stepCounter = 0;
        if (numbersBIN[numbersBIN.Count() - 1] == 1)
        {
            numbersBIN[numbersBIN.Count() - 1] = 0;
        }
        else
        {
            numbersBIN[numbersBIN.Count() - 1] = 1;
        }
        for (int x = numbersBIN.Count() - 2; x >= 0; x--)
        {
            
            stepCounter++;
            if (stepCounter == (step))
            {
                if (numbersBIN[x] == 1)
                {
                    numbersBIN[x] = 0;
                    stepCounter = 0;
                }
                else
                {
                    numbersBIN[x] = 1;
                    stepCounter = 0;
                }
            }
        }
         newBinN = 0;

        string string1 = "";
        for (int x= numbersBIN.Count()-1; x >= 0; x--)

        {
            newBinN++;
            string1 = string1 + numbersBIN[x];
         //   Console.Write(numbersBIN[x]);

            if (newBinN == 8)
            {
                
                int result = int.Parse(string1);
                string1 = Convert.ToString(Convert.ToInt32(string1, 2), 10);
           //     Console.WriteLine();
                Console.WriteLine(string1);
                string1 = "";
               
                newBinN = 0;
            }

        }
       
    }
    }

