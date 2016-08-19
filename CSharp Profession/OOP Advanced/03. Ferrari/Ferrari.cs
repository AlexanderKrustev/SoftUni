namespace _03.Ferrari
{
    using System;

    public class Ferrari
    {
        static void Main(string[] args)
        {
            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }

            string input = Console.ReadLine();
            ICar car=new Car(input);
            Console.WriteLine(car);

        }
    }
}
