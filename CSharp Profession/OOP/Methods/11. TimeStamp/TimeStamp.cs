namespace _11.TimeStamp
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TimeStamp
    {
        public List<Person> PList;
        public DateTime InitDateTime;

        public TimeStamp()
        {
            this.PList = new List<Person>();
            this.InitDateTime = DateTime.Now;
        }

        public void Add(string name)
        {
            this.PList.Add(new Person(name));
        }

        public void Set(string name, int pos)
        {
            this.PList[pos]=new Person(name);
        }

        public override string ToString()
        {
            StringBuilder sb =new StringBuilder();
            sb.Append("Initial time -> ");
            sb.AppendLine(this.InitDateTime.ToString("ddd MMM dd hh:mm:ss EEST yyyy"));
        
            for (int i = 0; i < this.PList.Count; i++)
            {
                sb.AppendLine($"Index {i} ({this.PList[i].name}) -> {this.PList[i].modificationDate.ToString("ddd MMM dd hh:mm:ss EEST yyyy")}");
            }
            return sb.ToString();
        }
    }
}
