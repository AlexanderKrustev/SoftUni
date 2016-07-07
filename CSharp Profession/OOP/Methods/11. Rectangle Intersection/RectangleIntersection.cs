namespace _11.Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {

            int[] lines =
            Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            Dictionary<string, Rectangle> rectangles=new Dictionary<string, Rectangle>();
            for (int i = 0; i < lines[0]; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string ID = input[0].Trim();
                double width = double.Parse(input[1]);
                double height = double.Parse(input[2]);
                double x = double.Parse(input[3]);
                double y = double.Parse(input[4]);

                if (!rectangles.ContainsKey(ID))
                {
                    rectangles.Add(ID, new Rectangle(ID, (int)x, (int)y, (int)width, (int)height));
                }
                else
                {
                    rectangles[ID]=new Rectangle( ID, (int)x, (int)y, (int)width, (int)height);
                }

            }

            for (int i = 0; i < lines[1]; i++)
            {
                string[] ids = Console.ReadLine().Split(' ');

                Console.WriteLine(rectangles[ids[0].Trim()].Intersect(rectangles[ids[1].Trim()].r));
               
            }

        }
    }

    public class Rectangle
    {
        public string id;
        public System.Drawing.Rectangle r;

        public Rectangle(string id, int x, int y, int width, int height)
        {
            this.id = id;
            this.r = new System.Drawing.Rectangle(x, y, width, height);
        }

        public string Intersect(System.Drawing.Rectangle rectangle)
        {
            if (this.r.IntersectsWith(rectangle))
            {
                return "true";
            }

            return "false";
        }
    }
}
