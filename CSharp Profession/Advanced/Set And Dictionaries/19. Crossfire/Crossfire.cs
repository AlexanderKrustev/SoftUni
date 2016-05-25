namespace _19.Crossfire
{
    using System;
    using System.Linq;

    public class Crossfire
    {
        public static void Main()
        {
            long[] dimesntions =
                Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            long[,] matrix = InitializeMatrix(dimesntions[0],dimesntions[1]);

            string input = Console.ReadLine();
            while (!input.Equals("Nuke it from orbit"))
            {

                long[] tagets =
                    input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(long.Parse)
                        .ToArray();

                matrix = HitOnTargets(tagets[0], tagets[1], tagets[2], matrix, dimesntions[0], dimesntions[1]);
                matrix = UpdateMatrix(matrix);

                input = Console.ReadLine();
            }

            for (long i = 0; i < matrix.GetLength(0); i++)
            {
                for (long j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static long[,] InitializeMatrix(long row, long col)
        {
            long[,] matrix=new long[row,col];
            long filler = 1;
            for (long i = 0; i < row; i++)
            {
                for (long j = 0; j < col; j++)
                {
                    matrix[i,j] = filler++;
                }
            }

            return matrix;
        }

        public static long[,] HitOnTargets(long row, long col, long radius, long[,] matrix, long dimR, long dimC)
        {
            if(ValidateTarget(row,col,dimR,dimC))
            {
                matrix[row,col] = 0;
            }

            for (long i = 1; i <= radius; i++)
            {
                if (ValidateTarget(row + i, col, dimR, dimC))
                {
                    matrix[row + i, col] = 0;
                }
            
                if (ValidateTarget(row - i, col, dimR, dimC))
                {
                    matrix[row - i, col] = 0;
                }
           
                if (ValidateTarget(row, col+i, dimR, dimC))
                {
                    matrix[row, col+i] = 0;
                }
            
                if (ValidateTarget(row, col-i, dimR, dimC))
                {
                    matrix[row,col-i] = 0;
                }
            }
            return matrix;
        }

        public static bool ValidateTarget(long row, long col, long dimR, long dimC)
        {
            if (row > dimR - 1  || row < 0)
            {
                return false;
            }
            if (col > dimC - 1 || col < 0)
            {
                return false;
            }
            return true;
        }

        public static long[,] UpdateMatrix(long[,] matrix)
        {
            
            long[,] resultMatrix=new long[matrix.GetLength(0),matrix.GetLength(1)];
            long rowc = 0;
            long colc = 0;
            bool updateRow = true;
            for (long i = 0; i < matrix.GetLength(0); i++)
            {
                for (long j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        resultMatrix[rowc, colc++] = matrix[i, j];
                        updateRow = true;
                    }
                }
                if (updateRow)
                {
                    rowc++;
                    updateRow = false;
                }
                colc = 0;
            }

            return resultMatrix;
        }

    }
}
