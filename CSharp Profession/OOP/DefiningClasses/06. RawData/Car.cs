using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RawData
{
   public class Car
    {
        public string model;
        public Tire tires;
        public Cargo cargo;
        public Engine engine;

        public Car(string model, int engineSpeed,
            int enginePower, int cargoWeight,
            string cargoType, double p1,
            int a1, double p2, int a2,
            double p3, int a3, double p4,
            int a4)
        {
            this.model = model;
            this.tires=new Tire(p1,a1,p2,a2,p3,a3,p4,a4);
            this.cargo=new Cargo(cargoType,cargoWeight);
            this.engine=new Engine(enginePower, engineSpeed);
        }
    }
}
