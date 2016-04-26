using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _02.CalculaateDistance
{
    public class Point3D
    {
        private double x;
        private double y;
        private double z;

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }


        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = x;
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("X:{0} ", this.X);
            output.AppendFormat("Y:{0} ", this.Y);
            output.AppendFormat("Z:{0} ", this.Z);
            return output.ToString();
        }
        
        public static double CalcDistance(Point3D p1,Point3D p2)
        {
            return Math.Sqrt(Math.Pow((p1.X - p2.X),2) + Math.Pow((p1.Y - p2.Y),2) + Math.Pow((p1.Z - p2.Z),2));
        }



    }
}
