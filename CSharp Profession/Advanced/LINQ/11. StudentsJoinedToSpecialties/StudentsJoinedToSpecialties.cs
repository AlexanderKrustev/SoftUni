namespace _11.StudentsJoinedToSpecialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public class StudentsJoinedToSpecialties
    {
        public static void Main()
        {
            List<Specialty> sp=new List<Specialty>();
            List<Student> st =new List<Student>();
            string input = Console.ReadLine();
            while (!input.Equals("Students:"))
            {   
                string[] pars = input.Split(new []{ ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string name = pars[0] + " " + pars[1];
                string fk = pars[2];
                sp.Add(new Specialty(name, fk));

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (!input.Equals("END"))
            {
                string[] pars = input.Split(new []{' ', '\t' ,'\n'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                //int index = input.LastIndexOf("4");
                string fk = pars[0].Trim();
               // string fk = input.Substring(0, index);
                string name = pars[1].Trim()+ " " + pars[2].Trim();
                //string name = input.Substring(index + 1, input.Length-1);
                st.Add(new Student(name.Trim(), fk.Trim()));

                input = Console.ReadLine();
            }

            var query = sp.Join(st,
                fkspec => fkspec.Fk,
                fkstud => fkstud.Fk,
                (fkspec, fkstud) =>
                    new
                    {
                        fkspec.Name,
                        fkspec.Fk,
                        fkstud.NameST,

                    });

            foreach (var gr in query.OrderBy(x=>x.NameST))
            {
                Console.WriteLine($"{gr.NameST} {gr.Fk} {gr.Name}");

            }
        }
    }

    public class Specialty
    {

        public Specialty(string name, string fk)
        {
            this.Name = name;
            this.Fk = fk;
        }

        public string Name { get; set; }
        public string Fk { get; set; }
    }

    public class Student
    {

        public Student(string name, string fk)
        {
            this.NameST = name;
            this.Fk = fk;
        }

        public string NameST { get; set; }
        public string Fk { get; set; }
    }
}
