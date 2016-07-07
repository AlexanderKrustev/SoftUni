namespace _08.PokemonTrainer
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Authentication.ExtendedProtection.Configuration;
    using System.Security.Cryptography.X509Certificates;
    using System.Xml.Schema;

    public class Trainer
    {
        public string name;
        public int badges;
        public List<Pokemon> pokemons;

        public Trainer(string name, string pokemonName, string pokemonEl, int health)
        {
            this.pokemons=new List<Pokemon>();
            this.name = name;
            this.badges = 0;
            this.pokemons.Add(new Pokemon(pokemonName, pokemonEl, health));
        }

        public Trainer Update(string element)
        {
            bool contains = false;
            foreach (var p in this.pokemons)
            {
                if (p.element.Equals(element))
                {
                    contains = true;
                    break;
                }
            }
            if (contains)
            {
                this.badges++;
            }
            else
            {
                for (int i = 0; i < this.pokemons.Count; i++)
                {
                    this.pokemons[i].health -= 10;
                    if (this.pokemons[i].health <= 0)
                    {
                        this.pokemons.RemoveAt(i);
                    }
                }
            }

            return this;
        }

        public override string ToString()
        {
            return string.Format($"{this.name} {this.badges} {this.pokemons.Count}");
        }
    }
}
