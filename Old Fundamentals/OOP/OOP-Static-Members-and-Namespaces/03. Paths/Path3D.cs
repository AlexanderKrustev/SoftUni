
using System.Collections.Generic;
using System;
using _02.CalculaateDistance;


namespace _03.Paths
{
    class Path3D
    {
        private List<Point3D> points;
        private double distance;

        public Path3D(List<Point3D> points)
        {
            this.points = points;
            this.distance = calculateDistance(this.points);
        }

        public double Distance
        {
            get { return this.distance; }
        }

        private double calculateDistance(List<Point3D> point3D)
        {
            double d = 0;
            for (int i = 0; i < point3D.Count - 1; i++)
            {
                d += _02.CalculaateDistance.Point3D.CalcDistance(point3D[i], point3D[i + 1]);
            }

            return d;
        }

        public override string ToString()
        {
            string path = "";

            for (int i = 0; i < points.Count; i++)
            {
                path += "Point " + (i + 1) + " coordinates: " + points[i].X + ", " + points[i].Y + ", " + points[i].Z +"\n";
            }
            path += "Distance between points: " + this.Distance + "\n\n";

            return path;
        }


    }
    }

