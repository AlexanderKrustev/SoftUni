namespace _09.Google
{
    public class Parent
    {
        public string name;
        public string bday;

        public Parent(string name, string bday)
        {
            this.name = name;
            this.bday = bday;
        }

        public Parent() { }

        public override string ToString()
        {
            return this.name + " " + this.bday;
        }
    }
}
