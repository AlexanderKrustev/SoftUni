namespace SystemSplit.Commands
{
    using Factories;
    using Models.HardwareComponents;
    using Repository;

    public abstract class RegisterHardware : Command
    {
        protected RegisterHardware(Data data, string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory)
            : base(data, input, hardwareFactory, softwareFactory)
        {
        }

        public override void Execute()
        {
            Hardware hardware = this.CreateHardware();
            this.AddHardware(hardware);
        }

        protected abstract Hardware CreateHardware();
        
        private void AddHardware(Hardware hard)
        {
            this.Data.AddHardware(hard);
        }
    }
}
