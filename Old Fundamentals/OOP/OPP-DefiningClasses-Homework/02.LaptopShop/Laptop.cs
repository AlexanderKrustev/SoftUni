using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        public Battery battery;
        private decimal price;
        
        public Laptop(string model,decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen,Battery battery, decimal price)
           : this(model,price)
        {
            
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.HDD = hdd;
            this.GraphicsCard = graphicsCard;
            this.Battery = battery;
            this.Screen = screen;
        }
        public string Model
        {

            set
            {
                if (value.Length > 1)
                {
                    this.model = value;
                }
                else
                {
                    throw new Exception("Model Value is not correct");
                }
            }
            get
            {
                return this.model;
            }
        }
        public string Manufacturer
        {
            set
            {
                if (value.Length > 1)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("Manufacturer Value is not correct");
                }
            }
            get
            {
                return this.manufacturer;
            }
        }
        public string Processor
        {
            set
            {
                if (value.Length > 1)
                {
                    this.processor = value;
                }
                else
                {
                    throw new ArgumentException("Processor Value is not correct");
                }
            }
            get
            {
                return this.processor;
            }
        }
        public Battery Battery
        {
            set
            {
                
                    this.battery = value;
               
            }
            get
            {
                return this.battery;
            }
        }
        public string RAM
        {
            set
            {
                if (value!=String.Empty)
                {
                    this.ram = value;
                }
                else
                {
                    throw new ArgumentException("Ram value is not correct");
                }
            }
            get
            {
                return this.ram;
            }
        }
        public string GraphicsCard
        {
            set
            {
                if (value.Length > 1)
                {
                    this.graphicsCard = value;
                }
                else
                {
                    throw new ArgumentException("Video Card Value is not correct");
                }
            }
            get
            {
                return this.graphicsCard;
            }
        }
        public string HDD
        {
            set
            {
                if (value != String.Empty)
                {
                    this.hdd = value;
                }
                else
                {
                    throw new ArgumentException("Manufacturer Value is not correct");
                }
            }
            get
            {
                return this.manufacturer;
            }
        }
            public string Screen
        {
            set
            {
                if (value != String.Empty)
                {
                    this.screen = value;
                }
                else
                {
                    throw new ArgumentException("Screen Value is not correct");
                }
            }
            get
            {
                return this.screen;
            }
        }
      
       
        public decimal Price
        {
            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("Price cannot be less than Zero");
                }
            }
            get
            {
                return this.price;
            }
        }

        public override string ToString()
        {
            String forPrint="";
            if (this.Screen!=null)
           {
              
               return string.Format("Laptop Model: {0}\nManufacturer: {1}\nProcessor: {2}\nRam: {3}\nGraphics Card: {4}\nHDD: {5}\nScreen: {6}\n{7}\nPrice: {8}lv",
                   this.Model, this.Manufacturer, this.Processor, this.RAM, this.GraphicsCard, this.HDD, this.Screen, this.battery.ToString(), this.Price);
             }
              else
             {
             forPrint= string.Format("Laptop Model: {0}\nPrice: {1}lv", this.Model , this.Price);
               return forPrint;
              }

        }
        
       

    }
}
