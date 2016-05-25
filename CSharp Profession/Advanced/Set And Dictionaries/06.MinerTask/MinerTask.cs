using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinerTask
{
    using System.Numerics;

    class MinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, BigInteger> mainer=new Dictionary<string, BigInteger>();
            string input = Console.ReadLine();
            int rowcounter = 1;
            string last = "";
            while (!input.Equals("stop"))
            {
                
                if (rowcounter%2 == 1)
                {
                    last = input;
                }
                else
                {
                    if (mainer.ContainsKey(last))
                    {
                        mainer[last] += BigInteger.Parse(input);
                    }
                    else
                    {
                        mainer.Add(last, BigInteger.Parse(input));
                    }

                    last = "";
                }
                input = Console.ReadLine();
                rowcounter++;
            }

            foreach (KeyValuePair<string, BigInteger> kvp in mainer)
            {
                Console.WriteLine("{0} -> {1}",kvp.Key,kvp.Value);
            }
        }
    }
}
