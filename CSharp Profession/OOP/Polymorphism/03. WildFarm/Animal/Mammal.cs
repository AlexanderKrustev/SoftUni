namespace _03.WildFarm.Animal
{
    using Food;

    public abstract class Mammal : Animal
    {
        protected Mammal(string animalType, string animalName, double animalWieght, string region)
            : base(animalType, animalName, animalWieght, region)
        {
        }

        public override void EatFood(Food f)
        {
            this.FoodEaten += f.QTY;
        }
    }
}