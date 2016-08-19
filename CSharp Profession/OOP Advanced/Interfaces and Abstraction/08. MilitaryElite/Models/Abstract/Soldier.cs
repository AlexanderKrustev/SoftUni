namespace _08.MilitaryElite.Models.Abstract
{

    using Interfaces;
    public abstract class Soldier : ISoldier
    {
        protected Soldier(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.Firstname = firstName;
            this.LastName = lastName;
        }

        public string ID { get; }
        public string Firstname { get; }
        public string LastName { get; }

    }
}
