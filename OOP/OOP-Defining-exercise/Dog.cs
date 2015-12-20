using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinningClases_Exercise
{
    class Dog
    {
        public string name;
        public string breed;

        public Dog()
        {

        }
        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name
        {
            get;
            set;

        }
        public string Breed
        {
            get;
            set;

        }

        public void Bark()
        {
            Console.WriteLine("{0} ({1}) said: Bauuuuu", this.Name ?? "[unnamed dog]", this.Breed ?? "[unknown breed]");
        }
    }
}
