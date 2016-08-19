namespace _08.MilitaryElite.Models
{
    using System.Text;
    using Interfaces;
    public class Mission : IMission
    {
        public Mission(string name, string state)
        {
            this.Name = name;
            this.State = state; 
        }


        public string Name { get; }
        public string State { get;  }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Code Name: {this.Name} State: {this.State}");

            return sb.ToString().TrimEnd();
        }

        public bool ValidateMission()
        {
            if (this.State == "inProgress" || this.State == "Finished")
            {
                return true;
            }

            return false;
        }
    }
}
