namespace SystemSplit.Commands
{
    using System;
    using Factories;
    using Repository;

    public abstract class Command
    {
        private string[] input;
        private Data data;
        private HardwareFactory hardwareFactory;
        private SoftwareFactory softwareFactory;

        protected Command(Data data, string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory)
        {
            this.input = input;
            this.data = data;
            this.hardwareFactory = hardwareFactory;
            this.softwareFactory = softwareFactory;
        }

        public abstract void Execute();

        protected Data Data => this.data;

        protected String[] Input => this.input;

        protected HardwareFactory HardwareFactory => this.hardwareFactory;

        protected SoftwareFactory SoftwareFactory => this.softwareFactory;

    }
}
