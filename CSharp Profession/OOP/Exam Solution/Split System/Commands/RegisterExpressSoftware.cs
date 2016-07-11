namespace SystemSplit.Commands
{
    using Factories;
    using Models.SoftwareComponents;
    using Repository;

    public class RegisterExpressSoftware : RegisterSoftware
    {
        public RegisterExpressSoftware(Data data, string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory)
            : base(data, input, hardwareFactory, softwareFactory)
        {
        }

        protected override Software CreateSoftware()
        {
            return this.SoftwareFactory.CreaExpressSoftware(this.Input);
        }
    }
}
