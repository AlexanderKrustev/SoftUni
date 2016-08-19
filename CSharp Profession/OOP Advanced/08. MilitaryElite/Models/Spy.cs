namespace _08.MilitaryElite.Models
{
    using System.Text;
    using Abstract;
    using Interfaces;

    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int code)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = code;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Firstname} {this.LastName} Id: {this.ID}");
            sb.AppendLine($"Code Number: {this.CodeNumber}");
            return sb.ToString().TrimEnd();
        }
    }
}
