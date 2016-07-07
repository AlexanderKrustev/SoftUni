namespace _08.ShapesVolume
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                string[] p = input.Split(' ');
                switch (p[0])
                {
                    case "Cylinder":
                        Cylinder cyl=new Cylinder(double.Parse(p[1]), double.Parse(p[2]));
                        Console.WriteLine("{0:f3}", VolumeCalculator.CalculateVolume(cyl));
                        break;
                    case "Cube":
                        Cube c= new Cube(double.Parse(p[1]));
                        Console.WriteLine("{0:f3}", VolumeCalculator.CalculateVolume(c));
                        break;
                    case "TrianglePrism":
                        TrianglePrism t= new TrianglePrism(double.Parse(p[1]), double.Parse(p[2]), double.Parse(p[3]));
                        Console.WriteLine("{0:f3}", VolumeCalculator.CalculateVolume(t));
                        break;
                   
                }

                input = Console.ReadLine();
            }
        }
    }

    public class TrianglePrism
    {
        public double baseSide;
        public double h;
        public double w;

        public TrianglePrism(double baseSide, double h, double w)
        {
            this.baseSide = baseSide;
            this.h = h;
            this.w = w;
        }
    }

    public class Cube
    {
        public double sideL;

        public Cube(double sideL)
        {
            this.sideL = sideL;
        }
    }

    public class Cylinder
    {
        public double radius;
        public double h;

        public Cylinder(double radius, double h)
        {
            this.radius = radius;
            this.h = h;
        }
    }

    public static class VolumeCalculator
    {
        public static double CalculateVolume(Cylinder c)
        {
            return Math.PI*Math.Pow(c.radius, 2)*c.h;
        }

        public static double CalculateVolume(Cube c)
        {
            return Math.Pow(c.sideL, 3);
        }

        public static double CalculateVolume(TrianglePrism c)
        {
            return (0.5*c.baseSide*c.h)*c.w;


        }
    }
}
