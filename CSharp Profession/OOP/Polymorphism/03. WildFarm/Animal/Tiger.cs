namespace _03.WildFarm.Animal
{
    using System;
    using Food;

    public class Tiger : Felime
    {
        public const string Type = "Tiger";

        public Tiger(string animalName, double animalWieght, string region)
            : base(Type, animalName, animalWieght, region)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void EatFood(Food f)
        {
            if (f.Type != "Meat")
            {
                //Console.WriteLine("Tigers are not eating that type of food!");
                AnimalCannotEat();
            }
            else
            {
                base.EatFood(f);
            }
        }
    }
}