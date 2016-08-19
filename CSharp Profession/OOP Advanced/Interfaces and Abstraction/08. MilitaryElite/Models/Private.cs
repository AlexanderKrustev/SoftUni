namespace _08.MilitaryElite.Models
{
    using System.Text;
    using Abstract;
    using Interfaces;

    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public double Salary { get; }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Name: {this.Firstname} {this.LastName} Id: {this.ID} Salary: {this.Salary:f2}");
            return sb.ToString().TrimEnd();
        }
    }
}
