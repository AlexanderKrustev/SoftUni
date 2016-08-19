namespace _05.BorderControl
{
    public class Rebel : IBuyer
    {

        public Rebel(string name, string age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public int TotalFood { get; set; }

        public string Name { get; }

        public string Age { get; }
        
        public string Group { get; set; }
        
        public void BuyFood()
        {
            this.TotalFood += 5;
        }
    }
}

