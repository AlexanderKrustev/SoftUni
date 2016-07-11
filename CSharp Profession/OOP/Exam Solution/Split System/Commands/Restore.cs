namespace SystemSplit.Commands
{
    using Factories;
    using Repository;

    public class Restore : Command
    {
        public Restore(Data data, string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory)
            : base(data, input, hardwareFactory, softwareFactory)
        {
        }

        public override void Execute()
        {
            string nameOfTheHardware = this.Input[1];
            this.Data.Restore(nameOfTheHardware);
        }
    }
}
