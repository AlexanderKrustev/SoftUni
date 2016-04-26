using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Square_Root
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            double number = 0;
            try
            {
                number= double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException ();
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Exception thrown: {0}",ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
