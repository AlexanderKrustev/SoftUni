namespace _09.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Goole
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> peopleInfo=new List<Person>();
            while (!input.Equals("End"))
            {
                string[] inputParams = input.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();
                string name = inputParams[0];
                int indexOfP = peopleInfo.FindIndex(x => x.name.Equals(name));
                string command = inputParams[1];
                if (indexOfP< 0)
                {
                    peopleInfo.Add(new Person(inputParams[0]));
                    indexOfP = peopleInfo.FindIndex(x => x.name.Equals(name));
                }

                if (command.Equals("company"))
                    {
                        peopleInfo[indexOfP].company = new Company(inputParams[2], inputParams[3],
                            decimal.Parse(inputParams[4]));
                        peopleInfo[indexOfP].hasCompany = true;
                    }
                    else if (command.Equals("pokemon"))
                    {
                        peopleInfo[indexOfP].pokemons.Add(new Pokemon(inputParams[2], inputParams[3]));
                    peopleInfo[indexOfP].hasPokemon = true;
                }
                    else if (command.Equals("parents"))
                    {
                        peopleInfo[indexOfP].parents.Add(new Parent(inputParams[2], inputParams[3]));
                    peopleInfo[indexOfP].hasParent = true;
                }
                    else if (command.Equals("children"))
                    {
                        peopleInfo[indexOfP].children.Add(new Child(inputParams[2], inputParams[3]));
                    peopleInfo[indexOfP].hasChild = true;
                }
                    else if (command.Equals("car"))
                    {
                        peopleInfo[indexOfP].car = new Car(inputParams[2], inputParams[3]);
                    peopleInfo[indexOfP].hasCar = true;
                }
               
                

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            int indexOf = peopleInfo.FindIndex(x => x.name.Equals(input));
            if (indexOf >= 0)
            {
                Console.WriteLine(peopleInfo[indexOf]);
            }
        }


    }
}
