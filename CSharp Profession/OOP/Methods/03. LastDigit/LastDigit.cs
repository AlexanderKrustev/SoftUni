
namespace _03.LastDigit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberHandler.TranslateLastDigit(n));
            
        }
    }

    public static class NumberHandler
    {
         public  static string TranslateLastDigit(int number)
        {
            if (number <= 9)
            {
                return  IntToString(number);
            }
            else
            {
                return  IntToString(TakeLastDigit(number));
            }
        }

        static int TakeLastDigit(int n)
        {
            return n%10;
        }

        public static string IntToString(int lastdigit)
        {
            switch (lastdigit)
            {
                case 1:
                    return  "one";
                    break;
                        case 2:
                    return  "two";
                    break;
                case 3:
                    return "three";
                    break;
                case 4:
                   return  "four";
                    break;
                case 5:
                    return  "five";
                    break;
                case 6:
                   return  "six";
                    break;
                case 7:
                    return  "seven";
                    break;
                case 8:
                    return  "eight";
                    break;
                case 9:
                    return  "nine";
                    break;
                case 0:
                    return  "zero";
                    break;
                default:
                    return "";
            }
            {
                    
            }
        }
    }
}
