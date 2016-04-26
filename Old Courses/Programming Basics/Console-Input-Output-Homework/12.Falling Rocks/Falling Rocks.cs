using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
class Program
    {

    private static void Drawing(int x,int y, string symbol)
    {
        Console.SetCursorPosition(x,y);
        Console.Write(symbol);
    }

    private static void DeletingLastDraw(int x, int y)
    {
        Drawing(x, y, " ");
    }
    static void Main(string[] args)
        {
        Console.CursorVisible = false;
      
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
     
        Random randomGenerator = new Random();
        int x = 35;
        Drawing((Console.BufferWidth - 1)/2, Console.BufferHeight - 1, "<--- (0) --->");
        int xObst = randomGenerator.Next(0,1);
        int yObst = randomGenerator.Next(1, Console.WindowHeight - 1);
      //  Drawing(Console.BufferWidth-1, Console.BufferHeight-1, "X");
      //  Drawing(0,0, "X");
      //  Drawing(0, Console.BufferHeight - 1, "X");
      //  Drawing(Console.BufferWidth - 1,0, "X");
        int onstpos = (Console.BufferHeight - 1) * xObst;
      //  Drawing(Console.BufferWidth - 1) * xObst, 0, "X");

        while (true)
        {

            if(onstpos< Console.BufferHeight){
                Drawing(35, onstpos, "X");
                if (onstpos > 0)
                {
                    DeletingLastDraw(35, onstpos - 1);
                }
                onstpos++;
               
            }
            else
            {
                if (onstpos == Console.BufferHeight && x >= 35 || x<=48)
                {
                    Drawing(0, 0, "Game over!!!!!!");
                    Drawing(35, Console.BufferHeight-2, "BAM BAM BAM BAM");
                }
                else
                {
                    DeletingLastDraw(35, Console.BufferHeight - 1);
                }
            }
            if (Console.KeyAvailable)
            {   
                DeletingLastDraw((Console.BufferWidth - 1) / 2, Console.BufferHeight - 1);
                DeletingLastDraw(((Console.BufferWidth - 1) / 2)+1, Console.BufferHeight - 1);
                DeletingLastDraw(((Console.BufferWidth - 1) / 2) + 2, Console.BufferHeight - 1);
                DeletingLastDraw(((Console.BufferWidth - 1) / 2) + 3, Console.BufferHeight - 1);
                DeletingLastDraw(((Console.BufferWidth - 1) / 2) + 4, Console.BufferHeight - 1);
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    x += 1;
                    
                        Drawing(x, Console.BufferHeight - 1, "<--- (0) --->");
                        DeletingLastDraw(x - 1, Console.BufferHeight - 1);
                    
                    

                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    x -= 1;
                    Drawing(x, Console.BufferHeight - 1, "<--- (0) --->");
                    DeletingLastDraw(x + 13, Console.BufferHeight - 1);
                }
            }
          
            


            Thread.Sleep(150);

        }
       
    }
    }

