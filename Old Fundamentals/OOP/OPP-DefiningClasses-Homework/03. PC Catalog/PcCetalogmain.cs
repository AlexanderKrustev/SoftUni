using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PC_Catalog
{
    class PcCetalogmain
    {
        static void Main(string[] args)
        {
            List<Component> parts = new List<Component>();
            Component part1 = new Component("Hdd", "250 gb", 100m);
            Component part2 = new Component("MB", "Foxcon", 100m);
            Component part3 = new Component("PSU", 100m);
            parts.Add(part1);
            parts.Add(part2);
            parts.Add(part3);


            Computer comp1 = new Computer("Super Comp", parts);
            Console.WriteLine(comp1.ToString());
        }
    }
}
