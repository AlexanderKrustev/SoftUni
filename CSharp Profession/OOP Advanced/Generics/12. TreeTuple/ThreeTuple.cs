using System.ComponentModel.Design;

namespace _12.TreeTuple
{
    public class ThreeTuple<TKey, TValue1, TValue2>
    {
        private TKey key;
        private TValue1 value1;
        private TValue2 value2;

        public ThreeTuple(TKey key, TValue1 value1, TValue2 value2)
        {
            this.key = key;
            this.value1 = value1;
            this.value2 = value2;
        }

        public TKey Key => this.key;

        public TValue1 FirstValue => this.value1;

        public TValue2 SecondValue => this.value2;
    }
}
