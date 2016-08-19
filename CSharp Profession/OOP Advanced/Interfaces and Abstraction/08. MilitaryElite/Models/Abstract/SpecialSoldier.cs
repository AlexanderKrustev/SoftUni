namespace _08.MilitaryElite.Models.Abstract
{
    
    using System.Text;
    using Interfaces;
    public abstract class SpecialSoldier : Soldier, ISpecialisedSoldier
    {
        protected SpecialSoldier(string id, string firstName, string lastName, double salary, string corpus) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Corpus = corpus;

        }

        public double Salary { get; }

        public string Corpus { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Firstname} {this.LastName} Id: {this.ID} Salary: {this.Salary:F2}");
            sb.AppendLine($"Corps: {this.Corpus}");
           
            return sb.ToString();
        }

        public bool ValidateCorpus()
        {
            if (this.Corpus== "Airforces" || this.Corpus == "Marines")
            {
                return true;
            }

            return false;
        }
    }
}
