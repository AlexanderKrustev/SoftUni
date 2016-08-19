namespace _08.MilitaryElite.Models
{
    using System.Text;
    using Interfaces;
    public class Part : IPart
    {
        public Part(string partName, int workedHours)
        {
            this.PartName = partName;
            this.WorkedHours = workedHours;
        }

        public string PartName { get; }
        public int WorkedHours { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Part Name: {this.PartName} Hours Worked: {this.WorkedHours}");
            return sb.ToString().TrimEnd();
        }
    }
}
