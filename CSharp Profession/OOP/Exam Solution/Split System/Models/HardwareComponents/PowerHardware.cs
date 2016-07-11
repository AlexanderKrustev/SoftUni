namespace SystemSplit.Models.HardwareComponents
{
    public class PowerHardware : Hardware
    {
        private const string Type = "Power";

        public PowerHardware(string name, int maxCapacity, int maxMemory)
            : base(Type, name, maxCapacity, maxMemory)
        {
        }

        public override int MaxCapacity
        {
           protected set { base.MaxCapacity = value-(value*3)/4; }
        }

        public override int MaxMemory
        {
            protected set { base.MaxMemory = value+(value*3)/4; }
        }
    }
}