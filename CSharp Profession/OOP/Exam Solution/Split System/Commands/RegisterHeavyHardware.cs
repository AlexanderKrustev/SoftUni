namespace SystemSplit.Commands
{
    using Factories;
    using Models.HardwareComponents;
    using Repository;

    public class RegisterHeavyHardware : RegisterHardware
    {
        public RegisterHeavyHardware(Data data, string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory)
            : base(data, input, hardwareFactory, softwareFactory)
        {
        }

        protected override Hardware CreateHardware()
        {
            return this.HardwareFactory.CreateHeavyHardware(this.Input);
        }
    }
}
