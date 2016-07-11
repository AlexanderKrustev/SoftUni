namespace SystemSplit.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Models.HardwareComponents;
    using Models.SoftwareComponents;

    public class Data
    {
        private Dictionary<string, Hardware> hardware;
        private Dictionary<string, Software> software;
        private Dictionary<string, Hardware> dumpedHardware;

        public Data()
        {
            InitData();
        }

        private void InitData()
        {
            this.hardware = new Dictionary<string, Hardware>();
            this.software = new Dictionary<string, Software>();
            this.dumpedHardware=new Dictionary<string, Hardware>();
        }

        public Dictionary<string, Hardware> Hardware => this.hardware;

        public Dictionary<string, Software> Software => this.software;

        public Dictionary<string, Hardware> DumpedHardware => this.dumpedHardware;

        public void AddHardware(Hardware h)
        {
            this.hardware.Add(h.Name, h);
        }
    
        public void Dump(string nameOfHardware)
        {
            if (this.Hardware.ContainsKey(nameOfHardware))
            {
                Hardware hardwareForDump = this.Hardware[nameOfHardware];
                this.dumpedHardware.Add(nameOfHardware, hardwareForDump);
                this.Hardware.Remove(nameOfHardware);
            }
        }

        public void Restore(string nameOfHardware)
        {
            if (this.DumpedHardware.ContainsKey(nameOfHardware))
            {
                Hardware hardwareForDump = this.dumpedHardware[nameOfHardware];
                this.hardware.Add(nameOfHardware, hardwareForDump);
                this.dumpedHardware.Remove(nameOfHardware);
            }
        }

        public void Destroy(string nameOfHardware)
        {
            if (this.DumpedHardware.ContainsKey(nameOfHardware))
            {
               this.dumpedHardware.Remove(nameOfHardware);
            }
        }

        public void PrintAnalyze()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("System Analysis");
            sb.AppendLine($"Hardware Components: {this.Hardware.Count}");
            sb.AppendLine($"Software Components: {this.Hardware.Values.Select(x => x.Software.Count).Sum()}");
            sb.AppendLine(
                $"Total Operational Memory: {this.Hardware.Sum(x => x.Value.MemoryInUse)} / {this.Hardware.Sum(x => x.Value.MaxMemory)}");
            sb.AppendLine(
               $"Total Capacity Taken: {this.Hardware.Sum(x => x.Value.CapacityInUse)} / {this.Hardware.Sum(x => x.Value.MaxCapacity)}");

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        public void PrintDumpAnalyze()
        {
            int countOfExpressSoftware = 0;
            int countOfLightSoftware = 0;

            foreach (var kvp in this.DumpedHardware)
            {
                foreach (var sf in kvp.Value.Software)
                {
                    if (sf.Type == "Express Software")
                    {
                        countOfExpressSoftware++;
                    }
                    else
                    {
                        countOfLightSoftware++;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dump Analysis");
            sb.AppendLine(
                $"Power Hardware Components: {this.DumpedHardware.Where(x => x.Value.Type == "Power").Count()}");
            sb.AppendLine(
                $"Heavy Hardware Components: {this.DumpedHardware.Where(x => x.Value.Type == "Heavy").Count()}");
            sb.AppendLine(
                $"Express Software Components: {countOfExpressSoftware}");
            sb.AppendLine(
                $"Light Software Components: {countOfLightSoftware}");
            sb.AppendLine($"Total Dumped Memory: {this.DumpedHardware.Values.Sum(x => x.MemoryInUse)}");
            sb.AppendLine($"Total Dumped Capacity: {this.DumpedHardware.Values.Sum(x => x.CapacityInUse)}");

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        public void PrintSystemSplit()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var kvp in this.Hardware)
            {
                sb.AppendLine($"Hardware Component - {kvp.Key}");
                sb.AppendLine(
                    $"Express Software Components - {kvp.Value.Software.Where(x => x.Type == "Express Software").Count()}");
                sb.AppendLine(
                  $"Light Software Components - {kvp.Value.Software.Where(x => x.Type == "Light Software").Count()}");
                sb.AppendLine($"Memory Usage: {kvp.Value.MemoryInUse} / {kvp.Value.MaxMemory}");
                sb.AppendLine($"Capacity Usage: {kvp.Value.CapacityInUse} / {kvp.Value.MaxCapacity}");
                sb.AppendLine($"Type: {kvp.Value.Type}");

                if (kvp.Value.Software.Count == 0)
                {
                    sb.AppendLine("Software Components: None");
                }
                else
                {
                    sb.AppendLine(string.Format("Software Components:{0}", string.Join(",", kvp.Value.Software)));
                }

                Console.WriteLine(sb.ToString().TrimEnd());
                sb.Clear();
            }
        }
    }
}
