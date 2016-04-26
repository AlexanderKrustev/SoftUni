using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CompoundInterest
    {
        static void Main()
        {
        System.Threading.Thread.CurrentThread.CurrentCulture =
     System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
        decimal priceTV = decimal.Parse(Console.ReadLine());
        int numberofYear = int.Parse(Console.ReadLine());
        double interest = double.Parse(Console.ReadLine());
        decimal interestFriend = decimal.Parse(Console.ReadLine());
        decimal resultBank = priceTV * (decimal)(Math.Pow((1 +interest),numberofYear));
        decimal resultFriend = priceTV * (1m + interestFriend) ;
        if (resultBank > resultFriend)
        {
            Console.WriteLine("{0:f2} Friend",resultFriend);
        }
        else
        {
            Console.WriteLine("{0:f2} Bank",resultBank);
        }

    }
    }

