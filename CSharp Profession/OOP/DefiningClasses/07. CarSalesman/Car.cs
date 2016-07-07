namespace _07.CarSalesman
{
    public class Car
    {
        public Engine engine;
        public string model;
        public string color;
        public string weight;

        public Car(string model, Engine engine, string weight = null, string color = null)
        {
            this.model = model;
            this.engine = engine;

            if (weight == null)
            {
                this.weight = "n/a";
            }
            else
            {
                this.weight = weight;
            }
            if (color == null)
            {
                this.color = "n/a";
            }
            else
            {
                this.color = color;
            }
        }

        public override string ToString()
        {

            return
                string.Format(
                    "{0}:\n  {1}:\n    Power: {2}\n  " +
                    "  Displacement: {3}\n    Efficiency: {4}\n " +
                    " Weight: {5}\n  Color: {6}", this.model, this.engine.model , this.engine.power, this.engine.displacement,
                    this.engine.efficiency, this.weight, this.color);
        }
    }
}
