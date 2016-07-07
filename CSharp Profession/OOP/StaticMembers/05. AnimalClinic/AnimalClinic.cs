namespace _05.AnimalClinic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    public  class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string,List<Animal>> animals=new Dictionary<string, List<Animal>>();

            animals.Add("heal", new List<Animal>());
            animals.Add("rehabilitate", new List<Animal>());

            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                string[] p = input.Split(' ');
                string name = p[0];
                string breed = p[1];
                string command = p[2];

                if (command.Equals("heal"))
                {
                    animals["heal"].Add(new Animal(name, breed));
                    AnimalClinic.healed++;
                    AnimalClinic.id++;
                    Console.WriteLine($"Patient {AnimalClinic.id}: [{name} ({breed})] has been healed!");

                }
                else
                {
                    animals["rehabilitate"].Add(new Animal(name, breed));
                    AnimalClinic.rehabilitated++;
                    AnimalClinic.id++;
                    Console.WriteLine($"Patient {AnimalClinic.id}: [{name} ({breed})] has been rehabilitated!");

                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            Console.WriteLine($"Total healed animals: {AnimalClinic.healed}");
            Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.rehabilitated}");
                foreach (var kvp in animals.Where(x=>x.Key.Equals(input)))
                {
                    foreach (var animal in kvp.Value)
                    {
                        Console.WriteLine($"{animal.name} {animal.breed}");
                    }
                }
           

        }
    }

    public class Animal
    {
        public string name;
        public string breed;

        public Animal(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }
    }

    public class AnimalClinic
    {
        public static int healed;
        public static int rehabilitated;
        public static int id = 0;



    }
}
