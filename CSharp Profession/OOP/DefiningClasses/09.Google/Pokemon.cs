namespace _09.Google
{
    using System;

    public class Pokemon
    {
        public string name;
        public string type;

        public Pokemon(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public override string ToString()
        {
            return this.name + " " + this.type;
        }
    }
}
