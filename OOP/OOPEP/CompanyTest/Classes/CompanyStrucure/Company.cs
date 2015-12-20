using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyTest.Classes.CompanyStrucure
{
    class Company
    {
        private string name;
        private List<SUB> departments;

        public Company(string company)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; } 
            set { this.name = value; }
        }

        public List<SUB> Departments
        {
            get { return this.departments; }
            set { this.departments = value; }
        }
    }
}
