namespace _04.BeerCounter
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                int[] p = input.Split(' ').Select(int.Parse).ToArray();
                BeerCounter.BuyBeer(p[0]);
                BeerCounter.DrikBeer(p[1]);

                input = Console.ReadLine();
            }

            Console.WriteLine($"{BeerCounter.beerInStock} {BeerCounter.beerDrank}");
        }
    }

    public class BeerCounter
    {
        public static int beerInStock;
        public static int beerDrank;

        public static void BuyBeer(int bottles)
        {
            beerInStock += bottles;
        }

        public static void DrikBeer(int bottles)
        {
            beerDrank += bottles;
            beerInStock -= bottles;
        }

    }
}
