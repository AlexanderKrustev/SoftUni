namespace _03.WildFarm.Animal
{
    using System;
    using Food;

    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWieght;
        public string AnimalLivingRegion { get; }
        private int foodEaten;

        protected Animal(string animalType, string animalName,  double animalWieght, string region)
        {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalWieght = animalWieght;
            this.AnimalLivingRegion = region;
        }

        public abstract void MakeNoise();

        public abstract void EatFood(Food f);

        public void AnimalCannotEat()
        {
            Console.WriteLine("{0}s are not eating that type of food!", this.AnimalType);
        }

        public override string ToString()
        {
            return string.Format("{0}[{1}, {2}, {3}, {4}]", this.animalType, this.animalName , this.animalWieght, this.AnimalLivingRegion, this.FoodEaten );
        }

        public int FoodEaten
        {
            get { return this.foodEaten;  }
            set { this.foodEaten = value; }
        }

        public string AnimalName
        {
            get
            {
                return animalName;
            }

            set
            {
                animalName = value;
            }
        }

        public string AnimalType
        {
            get
            {
                return animalType;
            }

            set
            {
                animalType = value;
            }
        }

        public double AnimalWieght
        {
            get
            {
                return animalWieght;
            }

            set
            {
                animalWieght = value;
            }
        }
    }
}