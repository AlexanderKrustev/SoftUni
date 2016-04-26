using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class LaptopShopMain
    {
        static void Main(string[] args)
        {
            Battery first = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5);
            Laptop fullInfo = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "Intel HD Graphics 4400",
                "128GB SSD", "\"13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display",first,  2259.00m);
            Laptop sampleInfo = new Laptop("HP 250 G2", 699.0m);

            Console.WriteLine("Full info: \n"+fullInfo.ToString());

            Console.WriteLine();
            Console.WriteLine("Sample info: \n"+sampleInfo.ToString());
        }
    }
}
