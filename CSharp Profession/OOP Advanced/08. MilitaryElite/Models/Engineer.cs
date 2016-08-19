namespace _08.MilitaryElite.Models
{
   
    using System.Collections.Generic;
    using System.Text;
    using Abstract;
    using Interfaces;
    public class Engineer : SpecialSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, double salary, string corpus, string[] repairs) 
            : base(id, firstName, lastName, salary, corpus)
        {
            this.Repairs=new List<IPart>();
            InitReapirs(repairs);
        }

        public void InitReapirs(string[] rep)
        {
            for (int i = 0; i < rep.Length-1; i=i+2)
            {
                this.Repairs.Add(new Part(rep[i], int.Parse(rep[i+1])));
            }
        }

        public IList<IPart> Repairs { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Repairs:");
            foreach (var r in this.Repairs)
            {
                sb.AppendLine("  "+ r);
            }

            return base.ToString() + sb.ToString().TrimEnd();
        }
    }
}
