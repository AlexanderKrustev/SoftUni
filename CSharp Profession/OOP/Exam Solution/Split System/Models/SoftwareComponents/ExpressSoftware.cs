namespace SystemSplit.Models.SoftwareComponents
{
    public class ExpressSoftware : Software
    {
        private const string Type = "Express Software";

        public ExpressSoftware(string hardware, string name, int capacityConsumption, int memoryConsumption) 
            : base(Type,hardware, name, capacityConsumption, memoryConsumption)
        {
        }

        public override int MemoryConsumption
        {
            protected set { base.MemoryConsumption = value*2; }
        }
    }
}