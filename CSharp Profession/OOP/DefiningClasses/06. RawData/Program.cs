namespace _06.RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars=new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weight = int.Parse(input[3]);
                string type = input[4];
                double p1 = double.Parse(input[5]);
                int a1 = int.Parse(input[6]);
                double p2 = double.Parse(input[7]);
                int a2 = int.Parse(input[8]);
                double p3 = double.Parse(input[9]);
                int a3 = int.Parse(input[10]);
                double p4 = double.Parse(input[11]);
                int a4 = int.Parse(input[12]);
                cars.Add(new Car(model,speed,power,weight,type,p1,a1,p2,a2,p3,a3,p4,a4));
            }

            string command = Console.ReadLine();
            if (command.Equals("fragile"))
            {
                foreach (var car in cars.Where(x => x.cargo.type.Equals("fragile") &&
                                                    (x.tires.pressure1 < 1
                                                     || x.tires.pressure2 < 1
                                                     || x.tires.pressure3 < 1
                                                     || x.tires.pressure4 < 1))) 
               
                {
                    Console.WriteLine(car.model);
                }
            }
            else
            {
                foreach (var car in cars.Where(x => x.cargo.type.Equals("flamable") && x.engine.power>250))
                                                    

                {
                    Console.WriteLine(car.model);
                }
            }
        }
    }
}
