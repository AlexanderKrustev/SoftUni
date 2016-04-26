using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicStrings
    {
        static void Main()
        {
        int diff = int.Parse(Console.ReadLine());
        List<int> firstFourNumbers = new List<int>();
        List<int> secondFourNumbers = new List<int>();
        for (int x = 0; x < 4; x++)
        {
            firstFourNumbers.Add(1);
            secondFourNumbers.Add(1);

        }
        for (int x = 3; x >=0; x--)
        {
            for(int z = 1; z <= 5; z++)
            {
                
                firstFourNumbers[x] = z;
               for(int h = 3; h >= 0; h--)
                {   
                    for(int y = 1; y <= 5; y++)
                    {
                        secondFourNumbers[h] = y;
                       
                        if (Math.Abs(firstFourNumbers.Sum() - secondFourNumbers.Sum()) == diff && firstFourNumbers[0] != 2 && firstFourNumbers[1] != 2 && firstFourNumbers[2] != 2 && firstFourNumbers[3] != 2 &&
                                secondFourNumbers[0] != 2 && secondFourNumbers[1] != 2 && secondFourNumbers[2] != 2 && secondFourNumbers[3] != 2)
                          {
                           
                                foreach (int f in firstFourNumbers)
                                {
                                    if (f == 1)
                                    {
                                        Console.Write("k");
                                    }
                                    else if(f == 3){

                                        Console.Write("s");
                                    }
                                    else if (f == 4)
                                    {

                                        Console.Write("n");
                                    }
                                    else if (f == 5)
                                    {

                                        Console.Write("p");
                                    }
                                }
                                foreach (int s in secondFourNumbers)
                                {
                                    if (s == 1)
                                    {
                                        Console.Write("k");
                                    }
                                    else if (s == 3)
                                    {

                                        Console.Write("s");
                                    }
                                    else if (s == 4)
                                    {

                                        Console.Write("n");
                                    }
                                    else if (s == 5)
                                    {

                                        Console.Write("p");
                                    }
                                }
                                /*Console.Write("{0}{1}{2}{3}", firstFourNumbers[0], firstFourNumbers[1], firstFourNumbers[2], firstFourNumbers[3]);
                                Console.WriteLine("  {0}{1}{2}{3}", secondFourNumbers[0], secondFourNumbers[1], secondFourNumbers[2], secondFourNumbers[3]);
                                Console.Write("{0}{1}{2}{3}", secondFourNumbers[0], secondFourNumbers[1], secondFourNumbers[2], secondFourNumbers[3]);
                             
                            Console.WriteLine("  {0}{1}{2}{3}", firstFourNumbers[0], firstFourNumbers[1], firstFourNumbers[2], firstFourNumbers[3]);*/
                              
                        }

                    }
              

                }
             //   Console.Write("sum = " + firstFourNumbers.Sum());
              //  Console.WriteLine();
             //   Console.Write("sum = " + secondFourNumbers.Sum());

            }
         //   Console.Write(firstFourNumbers[x]);
           Console.WriteLine();

        }
    }
    }
