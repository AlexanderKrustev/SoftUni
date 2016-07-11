namespace SystemSplit.Commands
{
    using Factories;
    using Repository;

    public class Destroy : Command
    {
        public Destroy(Data data, string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory)
            : base(data, input, hardwareFactory, softwareFactory)
        {
        }

        public override void Execute()
        {
            string nameOfHardware = this.Input[1];
            this.Data.Destroy(nameOfHardware);
        }
    }
}
