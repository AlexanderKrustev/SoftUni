namespace SystemSplit.Models.HardwareComponents
{
    using System.Collections.Generic;
    using System.Linq;
    using SoftwareComponents;

    public abstract class Hardware
    {
        private string type;
        private string name;
        private int maxCapacity;
        private int maxMemory;
        private int capacityInUse;
        private int memoryInUse;
        private List<Software> software;

        protected Hardware(string type, string name, int maxCapacity, int maxMemory)
        {
            this.type = type;
            this.name = name;
            this.MaxCapacity = maxCapacity;
            this.MaxMemory = maxMemory;
            this.software=new List<Software>();
        }

        public virtual int MaxCapacity
        {
            get { return this.maxCapacity; }
            protected set { this.maxCapacity = value; }
        }

        public virtual int MaxMemory
        {
            protected set { this.maxMemory = value; }
            get { return this.maxMemory; }
        }

        public string Name => this.name;

        public int CapacityInUse => this.capacityInUse;

        public int MemoryInUse => this.memoryInUse;

        public List<Software> Software => this.software;

        public string Type => this.type;

        public void RegisterSoftware(Software s)
        {
            this.capacityInUse += s.CapacityConsumption;
            this.memoryInUse += s.MemoryConsumption;
            this.software.Add(s);
        }

        public bool CanRegisterSoftware(Software soft)
        {
            if (soft.CapacityConsumption + this.capacityInUse <= this.maxCapacity
                && soft.MemoryConsumption + this.memoryInUse <= this.maxMemory)
            {
                return true;
            }

            return false;
        }

        public void ReleaseSoftware(string nameOfSoftware)
        {
            Software s = this.software.FirstOrDefault(x => x.Name.Equals(nameOfSoftware));
            if (s != null)
            {
                this.capacityInUse -= s.CapacityConsumption;
                this.memoryInUse -= s.MemoryConsumption;
                this.software.Remove(s);
            }
        }
    }
}