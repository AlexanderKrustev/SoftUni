using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyTest.Interfaces;

namespace CompanyTest.Classes.Employees
{
    public class Employee : ISalary
    {
        private string firstName;
        private string secondName;
        private string jobPosition;
        private decimal moneyAmount;

        public Employee(String fname, string sname, string jposition)
        {
            this.FirstName = fname;
            this.SecondName = sname;
            this.JobPosition = jposition;  
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string SecondName
        {
            get { return this.secondName; }
            set { this.secondName = value; }
        }
        public string JobPosition
        {
            get { return this.jobPosition; }
            set { this.jobPosition = value; }
        }
        public decimal MoneyAmount
        {
            get { return this.moneyAmount; }
            set { this.moneyAmount = value; }
        }

        public void PaySalary()
        {
            
        }

    }
}
