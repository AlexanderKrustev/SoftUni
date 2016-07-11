namespace SystemSplit.Factories
{
    using Models.HardwareComponents;

    public class HardwareFactory
    {
        public HeavyHardware CreateHeavyHardware(string[] input)
        {
            string name = input[1];
            int capacity = int.Parse(input[2]);
            int memory = int.Parse(input[3]);

            return new HeavyHardware(name, capacity, memory);
        }

        public PowerHardware CreatePowerHardware(string[] input)
        {
            string name = input[1];
            int capacity = int.Parse(input[2]);
            int memory = int.Parse(input[3]);

            return new PowerHardware(name, capacity, memory);
        }
    }
}
