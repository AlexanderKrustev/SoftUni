
using System.Text;

namespace _14.DrawingTool
{
    using System;
    using System.Text;


    public class Program
    {
        public static void Main()
        {
            string shape = Console.ReadLine();
           
            int w = 0;
            int h = 0;
            switch (shape)
            {
                case "Square":
                {
                    w = int.Parse(Console.ReadLine());
                    h = w;
                    
                }
                    break;
                case "Rectangle":
                {
                    w = int.Parse(Console.ReadLine());
                    h = int.Parse(Console.ReadLine());
                   
                }
                  break;
            }
            CorDraw sq=new CorDraw(w,h);
            Console.WriteLine(sq);
        }
    }


    public class CorDraw
    {
        public int width;
        public int height;

        public CorDraw(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();

            sb.AppendLine("|" +new string('-', this.width)+"|");
            for (int i = 0; i < this.height-2; i++)
            {
                sb.AppendLine("|" + new string(' ', this.width) + "|");
            }
            sb.AppendLine("|" + new string('-', this.width) + "|");
            return sb.ToString();
        }
    }
}


