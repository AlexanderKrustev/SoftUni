namespace _10.ExplicitInterfaces
{
    
    using Interfaces;

    public class Citizen : IPresident,IPerson
    {
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }


        public string Name { get; set; }
        public int Age { get; set; }
        string IPerson.GetName()
        {
            return this.Name;
        }


        public string Country { get; set; }
        string IPresident.GetName()
        {
            return "Mr/Ms/Mrs " + this.Name;
        }
    }
}
