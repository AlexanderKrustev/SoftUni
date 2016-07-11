namespace SystemSplit.Models.SoftwareComponents
{

    public class LightSoftware : Software
    {
        private const string Type = "Light Software";

        public LightSoftware(string hardware, string name, int capacityConsumption, int memoryConsumption)
            : base(Type,hardware, name, capacityConsumption, memoryConsumption)
        {
        }

        public override int CapacityConsumption
        {
            protected set { base.CapacityConsumption = value + (value/2); }
        }

        public override int MemoryConsumption
        {
            protected set { base.MemoryConsumption = value/2; }
        }
    }
}