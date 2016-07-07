using System;
using System.Linq;


namespace _08.Car
{
    using System.ComponentModel;

    class Program
    {
        static void Main()
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Car car= new Car(input[0], input[1], input[2]);
            string command = Console.ReadLine();

            while (!command.Equals("END"))
            {
                string[] com = command.Split();

                switch (com[0])
                {
                    case "Travel": car.Travel(double.Parse(com[1]));
                        break;
                    case "Distance":
                    {
                        Console.WriteLine("Total distance: {0:F1} kilometers", car.Distance);
                        
                    }
                        break;
                    case "Refuel":
                        car.Refuel(double.Parse(com[1]));
                         break;
                    case "Time":
                        Console.WriteLine($"Total time: {car.getTime()}");
                        break;
                    case "Fuel":
                        Console.WriteLine("Fuel left: {0:f1} liters",car.fuel);
                        break;
                }

                command = Console.ReadLine();
            }

        }
    }

    public class Car
    {
        public double speed;
        public double fuel;
        public double fuelEconomy;
        public double distance;
        public int h;
        public int m;


        public Car(double speed, double fuel, double fuelEconomy)
        {
            this.speed = speed;
            this.fuel = fuel;
            this.fuelEconomy = fuelEconomy;
            this.h = 0;
            this.m = 0;
        }

        public void Travel(double distance1)
        {
            if (fuel <= (distance1/100)*fuelEconomy)
            {
                this.distance = 100*(fuel/fuelEconomy);
                this.fuel = 0;
            }
            else
            {
                this.fuel -= (distance1 / 100)* this.fuelEconomy;
                this.distance += distance1;
            }
        }

        public void Refuel(double l)
        {
            this.fuel += l;
        }

        public double Distance => this.distance;

        public string getTime()
        {
            int allmins = (int)Math.Round(this.Distance/(this.speed))*60;
            

            while (allmins > 59)
            {
                h++;
                allmins -= 60;
            }

            m += allmins;
            return $"{h} hours and {m} minutes";
        }

        public double Fuel => this.fuel;
    }
}
