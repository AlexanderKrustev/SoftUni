namespace SystemSplit.Commands
{
    using Factories;
    using Models.SoftwareComponents;
    using Repository;

    public abstract class RegisterSoftware : Command
    {
        protected RegisterSoftware(Data data, string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory)
            : base(data, input, hardwareFactory, softwareFactory)
        {
        }

        protected abstract Software CreateSoftware();

        public override void Execute()
        {
            string nameOfHardware = this.Input[1];
            if (this.Data.Hardware.ContainsKey(nameOfHardware))
            {
                
                Software software = CreateSoftware();
                if (this.Data.Hardware[nameOfHardware].CanRegisterSoftware(software))
                {
                  
                    this.Data.Hardware[nameOfHardware].RegisterSoftware(software);
                }
            }
        }

        
    }
}
