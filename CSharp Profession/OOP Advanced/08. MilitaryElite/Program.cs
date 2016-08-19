namespace _08.MilitaryElite
{
    using System;
    using System.Linq;
    using Models;

    public class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            
            Data data=new Data();
            while (!input.Equals("End"))
            {
                string[] inputParameters = input.Split();

                string type = inputParameters[0];
                string id= inputParameters[1];
                string firstName = inputParameters[2];
                string lastName = inputParameters[3];
                
                switch (type)
                {
                    case "Private":
                    {
                            double salary = double.Parse(inputParameters[4]);
                            data.Privates.Add(id, new Private(id, firstName, lastName, salary));
                        data.Army.Add(new Private(id, firstName, lastName, salary));
                    }
                        break;
                    case "LeutenantGeneral":
                    {
                            double salary = double.Parse(inputParameters[4]);
                            string[] privs = inputParameters.Skip(5).ToArray();
                           data.Army.Add(new LeutenantGeneral(id, firstName, lastName, salary, privs, data));
                    }
                        break;
                    case "Commando":
                    {
                            double salary = double.Parse(inputParameters[4]);
                            string corpus = inputParameters[5];
                            string[] missions = inputParameters.Skip(6).ToArray();
                        var commando = new Commando(id, firstName, lastName, salary, corpus, missions);
                        if (commando.ValidateCorpus())
                        {
                            data.Army.Add(commando);
                        }
                    }
                    
                        break;
                    case "Engineer":
                    {
                            double salary = double.Parse(inputParameters[4]);
                            string corpus = inputParameters[5];
                            string[] parts = inputParameters.Skip(6).ToArray();
                            var engineer = new Engineer(id, firstName, lastName, salary, corpus, parts);
                            if (engineer.ValidateCorpus())
                            {
                                data.Army.Add(engineer);
                            }
                        }
                        break;
                    case "Spy":
                    {
                            int code = int.Parse(inputParameters[4]);
                            data.Army.Add(new Spy(id, firstName, lastName, code));
                        }
                        break;
                    default: throw new ArgumentException(type);
                }
                input = Console.ReadLine();
            }


            foreach (var soldier in data.Army)
            {
                Console.WriteLine(soldier);
            }
            var a = 0;
        }
    }
}
