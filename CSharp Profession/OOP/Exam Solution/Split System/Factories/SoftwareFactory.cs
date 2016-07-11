namespace SystemSplit.Factories
{
    using Models.SoftwareComponents;

    public class SoftwareFactory
    {

        public LightSoftware CreateLightSoftware(string[] input)
        {
            string hardware = input[1];
            string name = input[2];
            int capacity = int.Parse(input[3]);
            int memory = int.Parse(input[4]);

            return new LightSoftware(hardware, name, capacity, memory);
        }

        public ExpressSoftware CreaExpressSoftware(string[] input)
        {
            string hardware = input[1];
            string name = input[2];
            int capacity = int.Parse(input[3]);
            int memory = int.Parse(input[4]);

            return new ExpressSoftware(hardware, name, capacity, memory);
        }
    }
}
