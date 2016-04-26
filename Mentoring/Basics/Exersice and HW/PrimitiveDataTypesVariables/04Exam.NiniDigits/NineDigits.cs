using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int num2 = 0;
        int num3 = 0;
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int sum1 = 0;
        bool noNumber= true;
        for (int num1 = 111; num1 <= 777; num1++)
        {   
            num2 = diff + num1;
            num3 = 2 * diff + num1;
            if (num1 <= num2 && num2 <= num3)
            {
                int firtHunders = (num1 / (int)Math.Pow(10, 2)) % 10;
                int firstTenth = (num1 / (int)Math.Pow(10, 1)) % 10;
                int firstOnes = (num1 / (int)Math.Pow(10, 0)) % 10;

                int secondHunderds = (num2 / (int)Math.Pow(10, 2)) % 10;
                int secondTenth = (num2 / (int)Math.Pow(10, 1)) % 10;
                int secondOnes = (num2 / (int)Math.Pow(10, 0)) % 10;

                int thirdHundreds = (num3 / (int)Math.Pow(10, 2)) % 10;
                int thirdTenth = (num3 / (int)Math.Pow(10, 1)) % 10;
                int thirdOnes = (num3 / (int)Math.Pow(10, 0)) % 10;

                if (firtHunders > 0  && firtHunders < 8 && secondHunderds > 0 && secondHunderds < 8 && thirdHundreds > 0 && thirdHundreds < 8 &&
                    firstTenth > 0 && firstTenth < 8 && secondTenth > 0 && secondTenth < 8 && thirdTenth > 0 && thirdTenth < 8 && firstOnes > 0 && firstOnes < 8 && secondOnes > 0 &&
                    secondOnes < 8 && thirdOnes > 0 && thirdOnes < 8)
                {
                    sum1 = firtHunders + secondHunderds + thirdHundreds + firstTenth + secondTenth + thirdTenth + firstOnes + secondOnes + thirdOnes;
                    if (sum == sum1)
                    {
                        if(num2-num1 == diff && num3-num2 == diff)
                        {
                            Console.WriteLine("{0}{1}{2}",num1,num2,num3);
                            noNumber = false;
                        }
                    }
                    sum1 = 0;
                }
                
            }
           

        }
        if (noNumber)
        {
            Console.WriteLine("No");
        }

    }
}
    

