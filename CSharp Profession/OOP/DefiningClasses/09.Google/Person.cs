namespace _09.Google
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public string name;
        public Company company;
        public List<Pokemon> pokemons;
        public List<Parent> parents;
        public List<Child> children;
        public Car car;
        public bool hasCompany;
        public bool hasPokemon;
        public bool hasChild;
        public bool hasParent;
        public bool hasCar;

        public Person(string name)
        {
            this.name = name;
            this.company = new Company();
            this.pokemons = new List<Pokemon>();
            this.parents = new List<Parent>();
            this.children = new List<Child>();
            this.car = new Car();
        }

        public Company Company
        {
            set { this.company = value; }
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append(this.name+"\n");
            sb.Append("Company:\n");
            if ( this.hasCompany)
            {   
                string result=string.Format("{0} {1} {2:f2}", this.company.name, this.company.department,
                    this.company.salary);
                sb.Append(result+"\n");
            }
            sb.Append("Car:\n");
            if (this.hasCar)
            {
                sb.Append($"{this.car.model} {this.car.speed}\n");
            }
            sb.Append("Pokemon:\n");
            if (this.hasPokemon)
            {
                sb.Append(string.Join("\n", this.pokemons) + "\n");
            }
           
            sb.Append("Parents:\n");
            if (this.hasParent)
            {
                sb.Append(string.Join("\n", this.parents) + "\n");
            }
           
            sb.Append("Children:");
            if (this.hasChild)
            {
                sb.Append("\n"+string.Join("\n", this.children) + "\n");
            }
           
            return sb.ToString();
        }
    }
}
