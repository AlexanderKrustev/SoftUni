using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyTargetedCell
{
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            int[] dimenstions = Console.ReadLine()
                .Split(new[] {' '})
                .Select(int.Parse)
                .ToArray();

            int[][] matrix=new int[dimenstions[0]][];

            for (int i = 0; i < dimenstions[0]; i++)
            {
                matrix[i] =new int[dimenstions[1]];
               int[] row= Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToArray();
                row.CopyTo(matrix[i],0);
            }

            int[] targetedCell= Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToArray();

            int targetedRow = targetedCell[0];
            int targetedCol = targetedCell[1];
            int multipier = matrix[targetedRow][targetedCol];
            int sum = 0;

            for (int i = targetedRow-1; i <= targetedRow+1; i++)
            {
                for (int j = targetedCol-1; j <= targetedCol+1; j++)
                {
                    if (i != targetedRow || j != targetedCol)
                    {
                        sum += matrix[i][j];
                        matrix[i][j] *= multipier;
                    }
                }
            }
            matrix[targetedRow][targetedCol] *= sum;



            for (int i = 0; i < dimenstions[0]; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[i]));
            }

        }
    }
}
