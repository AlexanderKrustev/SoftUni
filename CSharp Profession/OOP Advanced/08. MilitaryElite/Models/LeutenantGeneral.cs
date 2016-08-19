namespace _08.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Text;
    using Abstract;
    using Interfaces;

    public class LeutenantGeneral : Soldier, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary, string[] privates, Data data)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Data = data;
            this.PrivList = privates;
            InitializePrivates();
        }

        public IList<IPrivate> PrivatesUnderCommand { get; private set; }

        private string[] PrivList { get; }

        private Data Data { get; }

        private void InitializePrivates()
        {
            this.PrivatesUnderCommand=new List<IPrivate>();

            foreach (var p in this.PrivList)
            {
                this.PrivatesUnderCommand.Add(ParsePrivate(p));
            }
        }

        private IPrivate ParsePrivate(string privs)
        {
            return this.Data.Privates[privs];
        }

        public double Salary { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Firstname} {this.LastName} Id: {this.ID} Salary: {this.Salary:F2}");
            sb.AppendLine("Privates:");
            foreach (var pr in this.PrivatesUnderCommand)
            {
                sb.AppendLine("  "+ pr);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
