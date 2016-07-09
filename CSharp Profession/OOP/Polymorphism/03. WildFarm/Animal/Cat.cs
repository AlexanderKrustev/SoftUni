namespace _03.WildFarm.Animal
{
    using System;
    using Food;

    public class Cat : Felime
    {
        public const string Type = "Cat";
        private string breed;

        public Cat(string animalName, double animalWieght, string region, string breed) 
            : base(Type, animalName, animalWieght, region)
        {
            this.breed = breed;
        }

        public string Breed => this.breed;

        public override void MakeNoise()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return string.Format("{0}[{1}, {2}, {3}, {4}, {5}]",Type, this.AnimalName, this.Breed, this.AnimalWieght, this.AnimalLivingRegion, this.FoodEaten);
        }


    }
}