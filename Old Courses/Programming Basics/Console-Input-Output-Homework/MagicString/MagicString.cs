using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MagicString
{

 public static string numberToSymbol(int x)
     {
         string str = "";
         switch (x)
         {
             case 1: { str = "k"; break; }
             case 3: { str = "s"; break; }
             case 4: { str = "n"; break; }
             case 5: { str = "p"; break; }

         }
         return str;
     }
     static void Main(string[] args)
     {
         bool noStrings = true;
         int diff = int.Parse(Console.ReadLine());
         List<string> firstNum = new List<string>();
         
         int sum1 = 0;
         int sum2 = 0;
         for (int n1 = 1; n1 <= 5; n1++)
         {
             

             for (int n2 = 1; n2 <= 5; n2++)
             {
                
                 for (int n3 = 1; n3 <= 5; n3++)
                 {
                     
                     for (int n4 = 1; n4 <= 5; n4++)
                     {
                         
                         sum1 = n1 + n2 + n3 + n4;
                         for (int n5 = 1; n5 <= 5; n5++)
                         {
                            
                             for (int n6 = 1; n6 <= 5; n6++)
                             {
                                 
                                 for (int n7 = 1; n7 <= 5; n7++)
                                 {
                                     
                                     for (int n8 = 1; n8 <= 5; n8++)
                                     {
                                        
                                         sum2 = n5 + n6 + n7 + n8;
                                         if (Math.Abs(sum1 - sum2) == diff && n1!=2 && n2!=2 && n3 != 2 && n4 != 2 && n5 !=2 && n6 != 2 && n7 != 2 && n8 != 2)
                                         {
                                             noStrings = false;
                                            firstNum.Add(numberToSymbol(n1)+numberToSymbol(n2)+numberToSymbol(n3)+numberToSymbol(n4)+ numberToSymbol(n5)+ numberToSymbol(n6)+ numberToSymbol(n7)+ numberToSymbol(n8));
                                            //Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", numberToSymbol(n1), numberToSymbol(n2), numberToSymbol(n3), numberToSymbol(n4), numberToSymbol(n5), numberToSymbol(n6), numberToSymbol(n7), numberToSymbol(n8));
                                         }
                                         sum2 = 0;
                                     }
                                 }
                             }
                         }
                         sum1 = 0;

                     }
                 }

                 
             }
         }
        firstNum.Sort();
        foreach(string y in firstNum)
        {
            Console.WriteLine(y);
        }
        if (noStrings)
        {
            Console.WriteLine("No");
        }
    }
  
}


    