namespace _03.WildFarm.Animal
{
    using System;
    using Food;

    public class Zebra : Mammal
    {
        public const string Type = "Zebra";


        public Zebra(string animalName, double animalWieght, string region)
            : base(Type, animalName, animalWieght, region)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Zs");
        }

        public override void EatFood(Food f)
        {
            if (f.Type != "Vegetable")
            {
                //Console.WriteLine("Zebras are not eating that type of food!");
                AnimalCannotEat();
            }
            else
            {
                base.EatFood(f);
            }

        }
    }
}