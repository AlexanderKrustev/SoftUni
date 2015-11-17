using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class InsideCircleOutsideRectangle
    {
        static void Main(string[] args)
        {
        Console.Write("x= ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y= ");
        double y = double.Parse(Console.ReadLine());
        int x0 = 1;
        int y0 = 1;
      
        if (Math.Pow((x-x0),2)+ Math.Pow((y - y0), 2) <= 1.5*1.5)
        {
            if (y < 1)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
        else
        {
            Console.WriteLine("no");
        }
    }
    }

