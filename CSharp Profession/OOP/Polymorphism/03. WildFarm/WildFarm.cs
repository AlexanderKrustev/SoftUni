namespace _03.WildFarm
{
    using System;
    using Factories;
    using Animal;

    public class WildFarm
    {
        static void Main()
        {
            string input = Console.ReadLine();
            AnimalFactory animalFactory=new AnimalFactory();
            FoodFactory foodFactory=new FoodFactory();
            Animal.Animal a;
            Food.Food food;
            while (!input.Equals("End"))
            {
                string[] animalInput = input.Split(' ');
                if (animalInput.Length == 4)
                {
                    a = animalFactory.CreateAnimal(animalInput[0], animalInput[1], double.Parse(animalInput[2]),
                        animalInput[3]);
                }
                else
                {
                    a = animalFactory.CreateAnimal(animalInput[0], animalInput[1], double.Parse(animalInput[2]),
                        animalInput[3],animalInput[4]);
                }

                string[] foodInput = Console.ReadLine().Split(' ');

                food = foodFactory.CreateFood(foodInput[0], int.Parse(foodInput[1]));

                a.MakeNoise();
                a.EatFood(food);
                Console.WriteLine(a);
                input = Console.ReadLine();
            }
        }
    }
}
