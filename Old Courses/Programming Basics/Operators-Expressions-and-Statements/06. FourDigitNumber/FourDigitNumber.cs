using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class FourDigitNumber
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
        int firstDigit = n % 10;
        int sedondDigit = (n / 10) % 10;
        int thirdDigit = (n / 100)%10;
        int fourthDigit = n / 1000;
        Console.WriteLine("Sum={0}",firstDigit+sedondDigit+thirdDigit+fourthDigit);
        Console.WriteLine("Reversed= {0}{1}{2}{3}", firstDigit,sedondDigit,thirdDigit,fourthDigit);
        Console.WriteLine("Last digit in front = {0}{1}{2}{3}",firstDigit, fourthDigit,thirdDigit,sedondDigit);
        Console.WriteLine("Second and third digits exchanged = {0}{1}{2}{3}", fourthDigit,sedondDigit,thirdDigit,firstDigit);
    }
    }

