namespace _07.CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CarSalesman
    {
        static void Main(string[] args)
        {
            int rowOfEngines=int.Parse(Console.ReadLine());
            List<Engine> engines=new List<Engine>();
            for (int i = 0; i < rowOfEngines; i++)
            {
                string[] input = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                if (input.Length == 2)
                {
                    engines.Add(new Engine(input[0], input[1]));
                }
                else if (input.Length == 3)
                {
                    int w = 0;
                    if (int.TryParse(input[2], out w))
                    {
                        engines.Add(new Engine(input[0], input[1],  input[2]));
                    }
                    else
                    {
                        engines.Add(new Engine(input[0], input[1],"n/a", input[2]));
                    }
                }
                else if (input.Length == 4)
                {
                    engines.Add(new Engine(input[0], input[1], input[2], input[3]));
                }
            }

            int rowOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < rowOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                var engine = engines.Where(x=>x.model.Equals(input[1])).FirstOrDefault();
                if (input.Length == 2)
                {
                    cars.Add(new Car(input[0], engine));
                }
                else if (input.Length == 3)
                {
                    int w = 0;
                    if (int.TryParse(input[2], out w))
                    {
                        cars.Add(new Car(input[0], engine, input[2]));
                    }
                    else
                    {
                        cars.Add(new Car(input[0], engine, "n/a", input[2]));
                    }
                }
                else if (input.Length == 4)
                {
                    cars.Add(new Car(input[0], engine, input[2], input[3]));
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
