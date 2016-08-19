namespace _08.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Text;
    using Abstract;
    using Interfaces;

    public class Commando : SpecialSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, double salary, string corpus, string[] missions)
            : base(id, firstName, lastName, salary, corpus)
        {
            InitMissions(missions);
        }

        public IList<IMission> Missions { get; private set; }

        private void InitMissions(string[] missions )
        {
            this.Missions=new List<IMission>();
            string miss = "";
            for (int i = 0; i <= missions.Length-1; i+=2)
            {
            

                    miss = missions[i + 1];
               
                var mission = new Mission(missions[i],miss );
                if (mission.ValidateMission())
                {
                    this.Missions.Add(mission);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Missions:");
            if (this.Missions.Count > 0)
            {
                foreach (var m in this.Missions)
                {
                    sb.AppendLine("  " + m);
                }
            }

            return base.ToString()+sb.ToString().TrimEnd();
        }
    }
}
