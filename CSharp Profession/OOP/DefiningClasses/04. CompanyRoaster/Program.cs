namespace _04.CompanyRoaster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Sockets;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography.X509Certificates;

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfrows= int.Parse(Console.ReadLine());
            List<Employee> employeesList= new List<Employee>();
            for (int i = 0; i < numberOfrows; i++)
            {
                string[] input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var emp = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3]);
                if (input.Length > 4)
                {
                    if (input.Length > 5)
                    {
                        emp.mail = input[4];
                        emp.age = int.Parse(input[5]);
                    }
                    else
                    {
                        if (input[4].Contains("@"))
                        {
                            emp.mail = input[4];
                        }
                        else
                        {
                            emp.age = int.Parse(input[4]);
                        }
                    }
                }
                employeesList.Add(emp);
            }
            Dictionary<string, decimal> result=new Dictionary<string, decimal>();

            for (int i = 0; i < employeesList.Count; i++)
            {
                if (result.ContainsKey(employeesList[i].department))
                {
                    result[employeesList[i].department] += employeesList[i].salary;
                    result[employeesList[i].department] /= 2.0m;
                }
                else
                {
                    result.Add(employeesList[i].department, employeesList[i].salary);
                }
            }

            var max = result.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            Console.WriteLine($"Highest Average Salary: {max}");
            foreach (var r in employeesList.Where(x=>x.department.Equals(max)).OrderByDescending(x=>x.salary))
            {
                Console.WriteLine("{0} {1:F2} {2} {3}",r.name,r.salary, r.mail, r.age);
            }

        }
    }
}
