namespace SystemSplit.Models.HardwareComponents
{
    public class HeavyHardware : Hardware
    {
        private const string Type = "Heavy";

        public HeavyHardware(string name, int maxCapacity, int maxMemory)
            : base(Type, name, maxCapacity, maxMemory)
        {
        }

        public override int MaxCapacity
        {
            protected set { base.MaxCapacity = value*2; }
        }

        public override int MaxMemory
        {
            protected set { base.MaxMemory = value-(value)/4; }
        }
    }
}