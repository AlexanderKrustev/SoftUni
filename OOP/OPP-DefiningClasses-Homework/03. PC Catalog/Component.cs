using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PC_Catalog
{
    public class Component
    {

        private string name;
        private string detail;
        private decimal price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                throw new ArgumentException("The name of the component cannot be empty");
                this.name = value;
            }
        }

        public string Detail
        {
            get { return this.detail; }
            set
            {
                if (value == null)
                throw new ArgumentException("The details of the component cannot be empty");
                this.detail = value;
            }

        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <0 )
                throw new ArgumentException("The price of the component cannot be negative or empty");
                this.price = value;
            }
        }

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Component(string name,string detail, decimal price)
            :this(name,price)
        {
            this.Detail = detail;
        }

        public override string ToString()
        {
            if (this.Detail != null)
            {
                return string.Format("Component Name: {0}\nDetails: {1}\n", this.Name, this.Detail);
            }
            else
            {
                return string.Format("Component Name: {0}\n", this.Name);
            }
        }

    }
}
