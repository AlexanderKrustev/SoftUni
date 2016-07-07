namespace _05.SpeedRacing
{
    using System;

    public class Car
    {
        public string model;
        public double fuelAmount;
        public double fuelCost;
        public double traveledDistance;

        public Car(string model, double fuelAmount, double fuelCost)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelCost = fuelCost;
            traveledDistance = 0;
        }

        public void Calculate(double km)
        {
            if (km*this.fuelCost <= fuelAmount)
            {
                this.fuelAmount -= (km*this.fuelCost);
                traveledDistance += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
