using System;
using System.Collections.Generic;

class OddAndEvenProduct
    {
        static void Main()
        {
        List<int> number = new List<int>();
        string str = Console.ReadLine();
        string[] strNumber = str.Split(' ');
        int productOdd = 1;
        int productEven = 1;
        foreach(string s in strNumber){
            number.Add(int.Parse(s));
        }
        for (int i = 0; i < (number.Count); i++)
        {
            if ((i+1) % 2 == 0)
            {
                productEven *= number[i];
            }
            else
            {
                productOdd *= number[i];
            }

        }
        if (productEven == productOdd)
        {

            Console.WriteLine("yes\nproduct={0}",productEven);
        }
        else
        {
            Console.WriteLine("no\n odd_product ={0}\n even_product={1}", productOdd,productEven);
        }
        }
    }

