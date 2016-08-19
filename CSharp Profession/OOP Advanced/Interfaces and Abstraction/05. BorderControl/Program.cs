namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public class Program
    {
       public static void Main(string[] args)
       {
           int count =int.Parse( Console.ReadLine());
            Dictionary<string, IBuyer> rebels = new Dictionary<string, IBuyer>();

           for (int i = 0; i < count; i++)
           {

                string[] parameters = Console.ReadLine().Split();

                switch (parameters.Length)
                {
                    case 4:
                        rebels.Add(parameters[0], new Citizen(parameters[0], parameters[1], parameters[2], parameters[3]));
                        break;
                    case 3:
                        rebels.Add(parameters[0], new Rebel(parameters[0], parameters[1], parameters[2]));
                        break;
                    default:
                        break;
                }

                
            }
            
           string input = Console.ReadLine();

           while (!input.Equals("End"))
           {
               if (rebels.ContainsKey(input))
               {
                   rebels[input].BuyFood();
               }

               input = Console.ReadLine();
           }

           Console.WriteLine(rebels.Values.Sum(x=>x.TotalFood));
           
             
         
       }
    }
}
