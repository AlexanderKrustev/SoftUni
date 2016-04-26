using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firefighting
{
    class Program
    {
        static void Main(string[] args)
        {
            int fireFighters = int.Parse(Console.ReadLine());
            bool isRunning = true;
            List<string> rows = new List<string>();
            int kids = 0;
            int adults = 0;
            int seniors = 0;
            int fire = fireFighters;
            while (isRunning)
            {
                string input = Console.ReadLine();
                if (input == "rain")
                {
                    isRunning = false;
                }
                else
                {
                    rows.Add(input);
                }
            }
            foreach(string n in rows)
            {
                int kidsInRow = 0;
                int adultsInRow = 0;
                int seniorsInRow = 0;
                foreach (char ch in n)
                {   

                    if (ch == 'K')
                    {
                        kidsInRow++;
                        
                    }
                    if (ch == 'A')
                    {
                        adultsInRow++;
                        
                    }
                    if (ch == 'S')
                    {
                        seniorsInRow++;
                        
                    }

                }
                if (kidsInRow > 0 && fireFighters > 0)
                {
                    if (kidsInRow > fireFighters)
                    {
                        kids += fireFighters;
                        fireFighters = 0;
                    }
                    else
                    {
                        kids += kidsInRow;
                        fireFighters = fireFighters - kidsInRow;
                    }
                }
                 if (adultsInRow > 0 && fireFighters > 0)
                     {
                        if (adultsInRow > fireFighters)
                        {
                        adults += fireFighters;
                        fireFighters = 0;
                    }
                        else
                        {
                        adults += adultsInRow;
                        fireFighters = fireFighters - adultsInRow;
                        }
                     }
                 if (seniorsInRow > 0 && fireFighters > 0)
                {
                    if (seniorsInRow > fireFighters)
                    {
                        seniors += fireFighters;
                        fireFighters = 0;
                    }
                    else
                    {
                        seniors += seniorsInRow;
                        fireFighters = fireFighters - seniorsInRow;
                    }
                }
                fireFighters = fire;
            }   
            Console.WriteLine("Kids: {0}", kids);
            Console.WriteLine("Adults: {0}", adults);
            Console.WriteLine("Seniors: {0}",seniors);
        }            
            
        }
    }

