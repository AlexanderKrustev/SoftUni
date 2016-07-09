namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private const double SummerConsumption=1.6;


        public Truck(double fuelQty, double fuelConsumtion, double tankCapacity)
            : base(fuelQty, fuelConsumtion, tankCapacity)
        {
        }

        public override double FuelConsumtion
        {
            set { base.FuelConsumtion =value+SummerConsumption; }
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters*0.95);
        }
    }
}
