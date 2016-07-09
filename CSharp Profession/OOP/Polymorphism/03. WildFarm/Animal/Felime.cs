namespace _03.WildFarm.Animal
{
    using Food;

    public abstract class Felime : Mammal
    {
        protected Felime(string animalType, string animalName, double animalWieght, string region)
            : base(animalType, animalName, animalWieght, region)
        {
        }

        
    }
}