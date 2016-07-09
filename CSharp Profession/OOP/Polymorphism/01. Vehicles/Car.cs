namespace _01.Vehicles
{
    using System;

    public  class Car : Vehicle
    {
        private const double SummerConsumption = 0.9;

        public Car(double fuelQty, double fuelConsumtion, double tankCapacity) 
            : base(fuelQty, fuelConsumtion, tankCapacity)
        {
        }

        public override double FuelConsumtion
        {
            set { base.FuelConsumtion=value+ SummerConsumption; }
        }

        public override void Refuel(double liters)
        {
            if (this.FuelQTY + liters > this.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                base.Refuel(liters);
            }
        }
    }
}
