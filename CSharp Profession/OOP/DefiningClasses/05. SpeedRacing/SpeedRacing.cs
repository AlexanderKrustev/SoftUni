namespace _05.SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SpeedRacing
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            List<Car> cars=new List<Car>();
            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                cars.Add(new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
            }
            string driveInput = Console.ReadLine();
            while (!driveInput.Equals("End"))
            {
                string[] inputArgs = driveInput.Split(' ');
                foreach (var c in cars)
                {
                    if (c.model.Equals(inputArgs[1]))
                    {
                        c.Calculate(double.Parse(inputArgs[2]));
                    }
                }
                driveInput = Console.ReadLine();
            }
          

            foreach (var c in cars)
            {
                Console.WriteLine("{0} {1:F2} {2}", c.model, c.fuelAmount, c.traveledDistance);
            }
           
        }
    }
}
