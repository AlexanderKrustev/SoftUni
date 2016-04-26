using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Enter_Numbers
{
    class EnterNumber
    {
        static void Main()
        {

            int startIndex = 1;
            int endIndex = 100;

            for(int x = 0; x < 10; x++)
            {
                ReadNumbers(startIndex,endIndex);
            }
        }

        public static void ReadNumbers(int startIndex, int endIndex)
        {

            bool isIncorrect = true;
            while (isIncorrect)
            {
                try
                {
                    Console.WriteLine("Please enter number in range [{0}....{1}", startIndex, endIndex);
                    double temp = double.Parse(Console.ReadLine());
                    if (temp < startIndex || temp > endIndex)
                    {
                        throw new ArgumentException();
                    }
                    isIncorrect = false;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("The number should be in valid limits [{0}...{1}]", endIndex, startIndex);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Exception thrown {0}", ex.Message);
                }
            }
        }
    }
}
