using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] array1 = { { 1, 3 }, { 5, 7 } };
            double[,] array2 = { { 4, 2 }, { 1, 5 } };
            double[,] result = Multiply(array1, array2);

            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int column = 0; column < result.GetLength(1); column++)
                {
                    Console.Write(result[row, column] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] Multiply(double[,] arrayArg1, double[,] arrayArg2)
        {
            if (arrayArg1.GetLength(1) != arrayArg2.GetLength(0))
            {
                throw new Exception("Error!");
            }

            
            double[,] result = new double[arrayArg1.GetLength(0), arrayArg2.GetLength(1)];
            for (int rows = 0; rows < arrayArg1.GetLength(0); rows++)
            {
                for (int columns = 0; columns < arrayArg2.GetLength(1); columns++)
                {
                    for (int temp = 0; temp < arrayArg1.GetLength(1); temp++)
                    {
                        result[rows, columns] += arrayArg1[rows, temp]*arrayArg2[temp, columns];
                    }

                }
            }
            return result;
        }
    }
}