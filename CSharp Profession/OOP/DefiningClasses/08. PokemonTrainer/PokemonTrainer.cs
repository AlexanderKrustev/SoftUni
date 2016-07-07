namespace _08.PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public class PokemonTrainer
    {
        static void Main()
        {
            string input=Console.ReadLine();
            List<Trainer> trainers=new List<Trainer>();
            while (!input.Equals("Tournament"))
            {
                string[] trainerArgs = input.Split();
                int indexof = trainers.FindIndex(x => x.name.Equals(trainerArgs[0]));
                if (indexof >= 0)
                {
                    trainers[indexof]
                        .pokemons.Add(new Pokemon(trainerArgs[1], trainerArgs[2], int.Parse(trainerArgs[3])));
                }
                else
                {
                    trainers.Add(new Trainer(trainerArgs[0], trainerArgs[1], trainerArgs[2], int.Parse(trainerArgs[3])));
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (!input.Equals("End"))
            {
                foreach (var trainer in trainers)
                {
                    trainer.Update(input);
                }
                input = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x=>x.badges))
            {
                Console.WriteLine(trainer);
            }



        }
    }
}
