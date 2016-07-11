namespace SystemSplit.Commands
{
    using System;
    using System.Linq;
    using System.Text;
    using Factories;
    using Repository;

    public class Analyze : Command
    {
        public Analyze(Data data, string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory) 
            : base(data, input, hardwareFactory, softwareFactory)
        {

        }

        public override void Execute()
        {
            this.Data.PrintAnalyze();
        }
    }
}
