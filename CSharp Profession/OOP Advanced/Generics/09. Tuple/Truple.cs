using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Tuple
{
    public class Truple<Tkey, TValue>
    {
        private Tkey key;
        private TValue value;

        public Truple(Tkey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

        public override string ToString()
        {
            return this.key + " -> " + this.value;
        }
    }
}
