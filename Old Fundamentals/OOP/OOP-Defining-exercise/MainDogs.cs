using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinningClases_Exercise
{
    class MainDogs
    {
        static void Main(string[] args)
        {

            Dog unnamed = new Dog();
            Dog sharo = new Dog("Sharo", "Melez");
            unnamed.Breed = "Germand Shepherd";


            unnamed.Bark();
            sharo.Bark();
        }
    }
}
