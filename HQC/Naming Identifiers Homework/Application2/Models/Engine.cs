using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2.Models
{
    public class Engine
    {
        public static void Staticsitcs(List<Player> points)
        {
            Console.WriteLine("Points");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} positions", i + 1, points[i].PlayerName, points[i].PlayerPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The statistic is empty");
            }
        }

        public static void NextMove(char[,] POLE, char[,] BOMBI, int RED, int KOLONA)
        {
            char kolkoBombi = kolko(BOMBI, RED, KOLONA);
            BOMBI[RED, KOLONA] = kolkoBombi;
            POLE[RED, KOLONA] = kolkoBombi;
        }

       public static void dumpp(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine("    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        public static char[,] CreateGameBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] gameBoard = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    gameBoard[i, j] = '?';
                }
            }

            return gameBoard;
        }

        public static char[,] PlaceMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] gameBoard = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    gameBoard[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int kol = i2 / columns;
                int red = i2 % columns;
                if (red == 0 && i2 != 0)
                {
                    kol--;
                    red = columns;
                }
                else
                {
                    red++;
                }

                gameBoard[kol, red - 1] = '*';
            }

            return gameBoard;
        }

        public static void smetki(char[,] pole)
        {
            int kol = pole.GetLength(0);
            int red = pole.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char kolkoo = kolko(pole, i, j);
                        pole[i, j] = kolkoo;
                    }
                }
            }
        }

        public static char kolko(char[,] r, int rr, int rrr)
        {
            int brojkata = 0;
            int rows = r.GetLength(0);
            int columns = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    brojkata++;
                }
            }

            if (rr + 1 < rows)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    brojkata++;
                }
            }

            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if (rrr + 1 < columns)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr - 1 >= 0) && (rrr + 1 < columns))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr + 1 < rows) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr + 1 < rows) && (rrr + 1 < columns))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            return char.Parse(brojkata.ToString());
        }
    }
}

