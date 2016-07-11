namespace SystemSplit.Models.SoftwareComponents
{
    public abstract class Software
    {
        private string hardwareName;
        private string type;
        private string name;
        private int capacityConsumption;
        private int memoryConsumption;

        protected Software(string type,string hardware, string name, int capacityConsumption, int memoryConsumption)
        {
            this.hardwareName = hardware;
            this.type = type;
            this.name = name;
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption;
        }

        public virtual int CapacityConsumption
        {
            get
            {
                return this.capacityConsumption;
            }

            protected set
            {
                this.capacityConsumption = value;
            }
        }

        public virtual int MemoryConsumption
        {
            get
            {
                return this.memoryConsumption;
            }

           protected set
            {
                this.memoryConsumption = value;
            }
        }

        public string Name => this.name;

        public string Type => this.type;

        public override string ToString()
        {
            return this.Name;
        }
    }
}