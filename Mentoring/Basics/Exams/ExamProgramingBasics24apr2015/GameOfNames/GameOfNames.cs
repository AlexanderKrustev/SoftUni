using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNames = int.Parse(Console.ReadLine());
            string winnerName = "";
            long winnerPoints = int.MinValue;
            for (int i = 0; i < numberOfNames; i++)
            {

                string currentName = Console.ReadLine();
                long currentPoint = long.Parse(Console.ReadLine());

                for (int j = 0; j <currentName.Length; j++)
                {

                    if ((long)currentName[j] % 2 == 0)
                    {
                        currentPoint += (long)currentName[j];
                    }
                    else
                    {
                        currentPoint -= (long)currentName[j];
                    }
                }

                if (currentPoint > winnerPoints)
                {
                    winnerPoints = currentPoint;
                    winnerName = currentName;
                }
            }

            Console.WriteLine("The winner is {0} - {1} points", winnerName, winnerPoints);
        }
    }
}
