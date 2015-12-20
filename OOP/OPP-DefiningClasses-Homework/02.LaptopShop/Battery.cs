using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Battery
    {
        public string model;
        public double life;

        public string Model
        {
            set
            {
                this.model = value;
            }
            get
            {
                return this.model;
            }
        }
        public double Life
        {
            set
            {
                this.life = value;
            }
            get
            {
               
                return this.life;
            }
        }
        public Battery(string model, double life)
        {
            this.Model = model;
            this.Life = life;
        }
        
        public override string ToString()
        {
         //   String result = "";
           // result+= "Battery Model:"+this.Model\n

            return string.Format("Battery Model: {0}\nBattery Life: {1}",this.Model,this.Life);
            

        }
    }
}
