namespace _09.Google
{
    public class Child
    {
        public string name;
        public string bday;

        public Child(string name, string bday)
        {
            this.name = name;
            this.bday = bday;
        }

        public Child() { }

        public override string ToString()
        {
            return this.name + " " + this.bday;
        }
    }
}
