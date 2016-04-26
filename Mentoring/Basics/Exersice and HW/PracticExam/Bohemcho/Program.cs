using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bohemcho
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int count = 0;
            List<uint> floors = new List<uint>();
            List<string> apartaments = new List<string>();
            while (isRunning)
            {
                string input = Console.ReadLine();
                string input2 = Console.ReadLine();
                if (input!= "Stop, God damn it" && input2!= "Stop, God damn it")
                {
                    floors.Add(uint.Parse(input));
                    apartaments.Add(input2);
                }
                else
                {
                    break;
                }
            }
            for(int x = 0; x < floors.Count; x++)
            {
                string[] apartament = apartaments[x].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach(string s in apartament)
                {
                    //Console.WriteLine(s);
                    int position = int.Parse(s);
                    uint number = floors[x];
                   // Console.WriteLine(number);
                    uint temp = number >> position;
                    uint result = temp & 1;
                    if (result == 0)
                    {
                        
                        uint mask = 1u << position;   
                        floors[x] = floors[x] | mask;
                       // Console.WriteLine("Binary representation of result: {0}", Convert.ToString(floors[x], 2).PadLeft(32, '0'));
                    }
                    else
                    {   
                        uint mask = ~(1u << position);
                        floors[x] =floors[x] & mask;
                       //onsole.WriteLine("Binary representation of result: {0}", Convert.ToString(floors[x], 2).PadLeft(32, '0'));
                    }
                }
            }
            
            foreach(uint i in floors)
            {
                for(int x = 0; x < 32; x++)
                {
                    uint number = i;
                    uint temp = number >> x;
                    uint result = temp & 1;
                    if (result == 1)
                    {
                        count++;
                    }
                    

                }
            }
            long resultFinal = 0;
            foreach(uint n in floors)
            {
                resultFinal += n;
            }
            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}",count, resultFinal);
        }
    }
}
