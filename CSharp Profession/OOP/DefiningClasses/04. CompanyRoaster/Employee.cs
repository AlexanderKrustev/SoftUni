namespace _04.CompanyRoaster
{
    using System.Collections.Specialized;

    public class Employee
    {
        public string name;
        public decimal salary;
        public string position;
        public string department;
        public string mail;
        public int age;

        public Employee(string name, decimal salary, string possition, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = possition;
            this.department = department;
            this.mail = "n/a";
            this.age = -1;
        }

    }
}
