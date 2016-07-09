namespace _03.WildFarm.Factories
{
    using System;
    using Animal;

    public class AnimalFactory
    {
        public Animal CreateAnimal(string type, string name, double weight, string region)
        {
            switch (type)
            {
                case "Zebra": return new Zebra(name, weight ,region);
                case "Mouse": return new Mouse(name, weight, region);
                case "Tiger": return new Tiger(name, weight, region);
                default:
                    throw new ArgumentException("Not valid animal type");
            }
        }

        public Animal CreateAnimal(string type, string name, double weight, string region, string breed)
        {
            return new Cat(name, weight,region,breed);
        }
    }
}
