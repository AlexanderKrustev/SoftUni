
namespace SystemSplit.Commands
{
    using Factories;
    using Repository;

    public class ReleaseSoftwareComponent : Command
    {
        public ReleaseSoftwareComponent(Data data, string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory)
            : base(data, input, hardwareFactory, softwareFactory)
        {
        }

        public override void Execute()
        {
            string nameOfHardware = this.Input[1];
            string nameOfSoftware = this.Input[2];
            if (this.Data.Hardware.ContainsKey(nameOfHardware))
            {
                this.Data.Hardware[nameOfHardware].ReleaseSoftware(nameOfSoftware);
                this.Data.Software.Remove(nameOfSoftware);
            }
        }
    }
}
