using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static  Point3D zeroPoint = new Point3D(0, 0, 0);

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
            StringBuilder output=new StringBuilder();
            output.AppendFormat("X: {0}{1}", this.X, Environment.NewLine);
            output.AppendFormat("Y: {0}{1}", this.Y, Environment.NewLine);
            output.AppendFormat("Z: {0}{1}", this.Z, Environment.NewLine);
            return output.ToString();
        }
        public static Point3D ZeroPoint
        {
            get { return zeroPoint; }
            
        }
        



    }
}
