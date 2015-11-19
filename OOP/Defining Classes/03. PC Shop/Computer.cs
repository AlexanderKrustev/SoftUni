using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PC_Catalog
{
    class Computer
    {
        private string computerName;
        private List<Component> details;
        private decimal price;

        public string ComputerName
        {
            get { return this.computerName; }
            set
            {
                this.computerName = value;
            }
        }
        public List<Component> Detail
        {
            get { return this.details; }
            set { this.details = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                this.price = 0;
            }
        }
        public Computer(string compName, List<Component> details)
        {
            this.ComputerName = compName;
            this.Detail = details;
            this.price = CalcPrice(details);
            
        }

        public decimal CalcPrice(List<Component> list)
        {
            decimal priceResult = 0;
            foreach(Component c in list)
            {
                priceResult += c.Price;
            }
            return priceResult;
        }

        public override string ToString()
        {
            String result = string.Format("PC Name: {0}\n", this.ComputerName);
            foreach(Component c in details)
            {
                result+=c.ToString();
            }
            return string.Format(result+"Price {0} BNG",this.Price);
        }
    }
}
