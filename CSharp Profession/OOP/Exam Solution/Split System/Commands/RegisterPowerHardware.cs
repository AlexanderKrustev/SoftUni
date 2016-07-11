
namespace SystemSplit.Commands
{
    using Factories;
    using Models.HardwareComponents;
    using Repository;

    public class RegisterPowerHardware : RegisterHardware
    {
        public RegisterPowerHardware(Data data,string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory)
            : base(data, input, hardwareFactory, softwareFactory)
        {

        }


        protected override Hardware CreateHardware()
        {
            return this.HardwareFactory.CreatePowerHardware(this.Input);
        }
    }
}
