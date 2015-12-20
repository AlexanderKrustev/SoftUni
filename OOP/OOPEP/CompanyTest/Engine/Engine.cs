using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyTest.Classes.CompanyStrucure;
using CompanyTest.Classes.Employees;

namespace CompanyTest.Engine
{
    class Engine
    {
        private Company company;
        private List<SUB> roots;
        private List<Employee> employees;


        public Company Company
        {
            set { this.company = value; }
            get { return this.company; }
        }

        public List<SUB> Roots
        {
            set { this.roots = value; }
            get { return this.roots; }
        }
        public List<Employee> Employees
        {
            set { this.employees = value; }
            get { return this.employees; }
        }
    }
}
