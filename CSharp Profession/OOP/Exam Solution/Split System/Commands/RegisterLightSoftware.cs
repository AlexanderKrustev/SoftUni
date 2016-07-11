namespace SystemSplit.Commands
{
    using Factories;
    using Models.SoftwareComponents;
    using Repository;

    public class RegisterLightSoftware : RegisterSoftware
    {
        public RegisterLightSoftware(Data data, string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory)
            : base(data, input, hardwareFactory, softwareFactory)
        {
        }

        protected override Software CreateSoftware()
        {
            return this.SoftwareFactory.CreateLightSoftware(this.Input);
        }
    }
}
