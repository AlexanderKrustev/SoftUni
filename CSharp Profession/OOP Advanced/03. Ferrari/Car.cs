namespace _03.Ferrari
{
    using System;

    public class Car : ICar
    {


        public Car(string name)
        {
            this.Driver = name;
            this.Model = "488-Spider";
        }

        public string Model { get; }

        public string Driver { get; }

        public string Brakes()
        {
           return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{Brakes()}/{Gas()}/{this.Driver}";
        }
    }
}
