using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TheFootballStatistician
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
     System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            decimal n = decimal.Parse(Console.ReadLine());
            List<string> matches = new List<string>();
            Dictionary<string, int> pointMap = new Dictionary<string, int>();
            int pointArsenal = 0;
            int pointChelsea = 0;
            int pointEverton = 0;
            int pointManchesterCity = 0;
            int pointManchesterUnited = 0;
            int pointLiverpool = 0;
            int pointTottenham = 0;
            int pointSouthampton = 0;
            decimal income = 0;
            while (true)
            {   
                
                string input = Console.ReadLine();
                if (input == "End of the league.")
                {
                    break;
                }
                else
                {
                    matches.Add(input);
                    income = income + n;
                }
            }
            foreach (string s in matches)
            {
               
                string[] array1 = s.Split(' ');
                List<string> array = new List<string>();
                foreach (string g in array1)
                {
                    if (g != "")
                    {

                        array.Add(g);
                    }
                }
                if (s.Contains("1"))
                {
                    switch (array[0])
                    {
                        case "Arsenal":pointArsenal+=3; break;
                        case "Chelsea":pointChelsea+=3; break;
                        case "Everton":pointEverton += 3; break;
                        case "ManchesterCity":pointManchesterCity += 3; break;
                        case "ManchesterUnited":pointManchesterUnited += 3; break;
                        case "Liverpool":pointLiverpool += 3; break;
                        case "Tottenham":pointTottenham += 3; break;
                        case "Southampton":pointSouthampton += 3; break;
                    }  
                }
                if (s.Contains("2"))
                {
                    switch (array[2])
                    {
                        case "Arsenal": pointArsenal += 3; break;
                        case "Chelsea": pointChelsea += 3; break;
                        case "Everton": pointEverton += 3; break;
                        case "ManchesterCity": pointManchesterCity += 3; break;
                        case "ManchesterUnited": pointManchesterUnited += 3; break;
                        case "Liverpool": pointLiverpool += 3; break;
                        case "Tottenham": pointTottenham += 3; break;
                        case "Southampton": pointSouthampton += 3; break;
                    }
                }
                if (s.Contains("X"))
                {
                    switch (array[0])
                    {
                        case "Arsenal": pointArsenal ++; break;
                        case "Chelsea": pointChelsea ++; break;
                        case "Everton": pointEverton ++; break;
                        case "ManchesterCity": pointManchesterCity ++; break;
                        case "ManchesterUnited": pointManchesterUnited ++; break;
                        case "Liverpool": pointLiverpool ++; break;
                        case "Tottenham": pointTottenham ++; break;
                        case "Southampton": pointSouthampton ++; break;
                    }
                    switch (array[2])
                    {
                        case "Arsenal": pointArsenal++; break;
                        case "Chelsea": pointChelsea++; break;
                        case "Everton": pointEverton++; break;
                        case "ManchesterCity": pointManchesterCity++; break;
                        case "ManchesterUnited": pointManchesterUnited++; break;
                        case "Liverpool": pointLiverpool++; break;
                        case "Tottenham": pointTottenham++; break;
                        case "Southampton": pointSouthampton++; break;
                    }
                }

            }
            Console.WriteLine("{0:f2}lv.", income*1.94m);
            Console.WriteLine("Arsenal - {0} points.", pointArsenal);
            Console.WriteLine("Chelsea - {0} points.", pointChelsea);
            Console.WriteLine("Everton - {0} points.", pointEverton);
            Console.WriteLine("Liverpool - {0} points.", pointLiverpool);
            Console.WriteLine("Manchester City - {0} points.", pointManchesterCity);
            Console.WriteLine("Manchester United - {0} points.", pointManchesterUnited);
            Console.WriteLine("Southampton - {0} points.", pointSouthampton);
            Console.WriteLine("Tottenham - {0} points.", pointTottenham);
            

        }
    }
}

