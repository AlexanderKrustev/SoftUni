namespace _01.Vehicles
{
    using System;

    public class Bus: Vehicle
    {
        private const double airCmodifier = 1.4;
       

        public Bus(double fuelQty, double fuelConsumtion, double tankCapacity) 
            : base(fuelQty, fuelConsumtion, tankCapacity)
        {
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

   


        protected override void DriveDistance(double distance, string type, bool isEmpty)
        {
            if (isEmpty)
            {
                this.FuelConsumtion += airCmodifier;
            }
          
            base.DriveDistance(distance, type, isEmpty);
        }
       

    }
}
