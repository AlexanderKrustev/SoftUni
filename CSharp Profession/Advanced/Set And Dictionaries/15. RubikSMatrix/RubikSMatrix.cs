
namespace _15.RubikSMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    public class RubikSMatrix
    {
        public static void Main()
        {
            int[] dimetions =
                Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int[,] matrix = InitializeMatrix(dimetions[0], dimetions[1]);

            int commandCount=int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string input = Console.ReadLine();
                string[] commands = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                matrix = CommandMatrixUpdater(commands[0], commands[1], commands[2], matrix);

                //PrintMatrinx(matrix);
            }

            
            MatrixSwapper(matrix);

           
        }

        private static void PrintMatrinx(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[j, k] + " ");
                }
                Console.WriteLine();
            }
        }


        public static int[,] InitializeMatrix(int row, int col)
        {
            int[,] matrix = new int[row,col];
            int filler = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = filler++;
                }
            }

            return matrix;
        }

        public static int[,] CommandMatrixUpdater(string index, string direction, string count, int[,] matrix)
        {
            Queue<int> q = new Queue<int>();
            int times = int.Parse(count);
            if (direction.Equals("down"))
            {
                int col = int.Parse(index);
                for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                {
                    q.Enqueue(matrix[i, col]);
                }

                for (int i = 0; i < times % matrix.GetLength(0); i++)
                {
                    q.Enqueue(q.Dequeue());
                }
                for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                {
                    matrix[i, col] = q.Dequeue();
                }
            }
            else if (direction.Equals("up"))
            {
                int col = int.Parse(index);
                for (int i = 0; i< matrix.GetLength(0); i++)
                {
                    q.Enqueue(matrix[i, col]);
                }

                for (int i = 0; i < times%matrix.GetLength(0); i++)
                {
                    q.Enqueue(q.Dequeue());
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, col] = q.Dequeue();
                }
            }
            else if (direction.Equals("left"))
            {
                int row = int.Parse(index);
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    q.Enqueue(matrix[row, i]);
                }

                for (int i = 0; i < times%matrix.GetLength(1); i++)
                {
                    q.Enqueue(q.Dequeue());
                }
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[row, i] = q.Dequeue();
                }
            }
            else if (direction.Equals("right"))
            {
                int row = int.Parse(index);
                for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
                {
                    q.Enqueue(matrix[row, i]);
                }

                for (int i = 0; i < times%matrix.GetLength(1); i++)
                {
                    q.Enqueue(q.Dequeue());
                }
                for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
                {
                    matrix[row, i] = q.Dequeue();
                }
            }
    
         return matrix;
        }

        public static void MatrixSwapper(int[,] matrix)
        {
            int model = 1;
            int target = 0;
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == model)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        target = model;

                        for (int k = 0; k < matrix.GetLength(0); k++)
                        {
                            for (int l = 0; l < matrix.GetLength(1); l++)
                            {
                                if (target == matrix[k, l])
                                {
                                    matrix[k, l] = matrix[i, j];
                                    matrix[i, j] = target;
                                    Console.WriteLine($"Swap ({i}, {j}) with ({k}, {l})");
                                    break;
                                }
                            }
                        }
                    }
                  
                    model++;
                }
            }
        }
    }
}
