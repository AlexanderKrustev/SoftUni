namespace _07.CarSalesman
{
    public class Engine
    {
        public string model;
        public string power;
        public string displacement;
        public string efficiency;

        public Engine(string model, string power, string displacement = null, string efficiency = null)
        {
            this.model = model;
            this.power = power;
            if (displacement == null)
            {
                this.displacement = "n/a";
            }
            else
            {
                this.displacement = displacement;
            }
            if (efficiency == null)
            {
                this.efficiency = "n/a";
            }
            else
            {
                this.efficiency = efficiency;
            }
           
        }
    }
}
