using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program    //Grand Theft Examo
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
     System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            long escapeAttempts = long.Parse(Console.ReadLine());
            long slaped = 0;
            long escaped = 0;
       
            long resultBeers = 0;
            for (int x = 0; x < escapeAttempts; x++)
            {
                long thefts = long.Parse(Console.ReadLine());
                long beers = long.Parse(Console.ReadLine());
                resultBeers += beers;
                if (thefts >= 5)
                {
                    escaped+= Math.Abs(thefts - 5);
                    slaped += 5;
                }
                else
                {
                    slaped += thefts;
                }
            }
            
           Console.WriteLine("{0} thieves slapped.",slaped);
            Console.WriteLine("{0} thieves escaped.", escaped);
            Console.WriteLine("{0} packs, {1} bottles.",resultBeers/6,resultBeers%6);
        }

    }
}
