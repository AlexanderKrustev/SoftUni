namespace _03.WildFarm.Animal
{
    using System;
     using Food;

    public class Mouse : Mammal
    {
        public const string Type = "Mouse";

        public Mouse (string animalName, double animalWieght, string region) 
            : base(Type, animalName, animalWieght, region)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override void EatFood(Food f)
        {
            if (f.Type != "Vegetable")
            {
                //Console.WriteLine("Mouses are not eating that type of food! ");
                AnimalCannotEat();
            }
            else
            {
                Console.WriteLine("A cheese was just eaten!");
                base.EatFood(f);
            }
        }
    }
}