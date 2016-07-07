using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ConvertsTempreture
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
           
            while (!input.Equals("End"))
            {
                string[] p = input.Split(' ');
                switch (p[1])
                {
                    case "Fahrenheit":
                        Console.WriteLine(FaremheitToCelsuis(int.Parse(p[0])));
                        break;
                    case "Celsius":
                        Console.WriteLine(CelsuisToFarenhiet(int.Parse(p[0])));
                        break;
                }

                input = Console.ReadLine();
            }

            
        }


        static string CelsuisToFarenhiet(int tempreture)
        {
            double result = tempreture*1.8 + 32;
            return string.Format("{0:f2} Fahrenheit", result);
        }

        static string FaremheitToCelsuis(int tempreture)
        {
            double result = (tempreture -32)/1.8;
            return string.Format("{0:f2} Celsius", result);
        }

    }

}
