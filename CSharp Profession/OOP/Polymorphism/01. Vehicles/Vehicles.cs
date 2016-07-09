namespace _01.Vehicles
{
    using System;

    public class Vehicles
    {
        static void Main()
        {

            string[] inputCar = Console.ReadLine().Split(' ');
            string[] inputTruck = Console.ReadLine().Split(' ');
            string[] inputBus = Console.ReadLine().Split(' ');
            double carFuelQty = double.Parse(inputCar[1]);
            double carfuelPerKM = double.Parse(inputCar[2]);
            double carfuelCapcity = double.Parse(inputCar[3]);
            Vehicle car = new Car(carFuelQty, carfuelPerKM, carfuelCapcity);

            double truckFuelQty = double.Parse(inputTruck[1]);
            double truckfuelPerKM = double.Parse(inputTruck[2]);
            double truckfuelCapacity = double.Parse(inputTruck[3]);
            Vehicle truck = new Truck(truckFuelQty, truckfuelPerKM, truckfuelCapacity);

            double busFuelQty = double.Parse(inputBus[1]);
            double busfuelPerKM = double.Parse(inputBus[2]);
            double busfuelCapacity = double.Parse(inputBus[3]);
            Vehicle bus = new Bus(busFuelQty, busfuelPerKM, busfuelCapacity);


            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(' ');

                switch (commands[1])
                {
                    case "Car":
                    {
                        if (commands[0].Equals("Drive"))
                        {
                            double distance = double.Parse(commands[2]);
                            car.CanDriveGivenDistance(distance, "Car", true);
                        }
                        else
                        {
                            double fuel = double.Parse(commands[2]);
                            car.Refuel(fuel);
                        }
                        break;
                    }
                    case "Truck":
                    {
                        if (commands[0].Equals("Drive"))
                        {
                            double distance = double.Parse(commands[2]);
                            truck.CanDriveGivenDistance(distance, "Truck", true);
                        }
                        else
                        {
                            double fuel = double.Parse(commands[2]);
                            truck.Refuel(fuel);
                        }
                        break;
                    }
                    case "Bus":
                        {
                            if (commands[0].Equals("Drive"))
                            {
                                double distance = double.Parse(commands[2]);
                                bus.CanDriveGivenDistance(distance, "Bus", true);
                            }
                            else if (commands[0].Equals("DriveEmpty"))
                            {
                                
                                double distance = double.Parse(commands[2]);
                                bus.CanDriveGivenDistance(distance, "Bus", false);
                            }
                            else
                            {
                                double fuel = double.Parse(commands[2]);
                                bus.Refuel(fuel);
                            }

                            break;
                        }

                }
            }
            Console.WriteLine("Car: {0:f2}",car.FuelQTY);
            Console.WriteLine("Truck: {0:f2}", truck.FuelQTY);
            Console.WriteLine("Bus: {0:f2}", bus.FuelQTY);
        }
    }
}
   