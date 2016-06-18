using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.GroupByGroup
{
    using System.Text.RegularExpressions;

    public class Program
    {
        static void Main()
        {

            List<Person> l=new List<Person>();
            string input = Console.ReadLine();
            while (!input.Equals("END"))
            {

                string[] pars = input.Split(' ');
                string name = pars[0] + " " +pars[1];
                int group = int.Parse(pars[2]);

                l.Add(new Person(name,group));
                
                input = Console.ReadLine();
            }

            var grouped=l.GroupBy(x => x.Group,
                x => x.Name,
                (group, name) => new
                {
                    Group = group,
                    Name = name.ToList(),
                }
                );
            foreach (var gr in grouped.OrderBy(x=>x.Group))
            {
                Console.WriteLine("{0} - {1}",gr.Group,string.Join(", ",gr.Name));
            }

        }
    }

    public class Person
    {
        
        public Person(string name, int group)
        {
            this.Name = name;
            this.Group = group;
        }

        public string Name { get; set; }
        public int Group { get; set; }
        
    }
}
