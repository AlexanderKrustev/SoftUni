
namespace _08.CustomList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;


    public class MyList<T>: IEnumerable<T>,ICustomList<T> where T: IComparable
    {
        private List<T> innerList;

        public MyList()
        {
            this.innerList = new List<T>();
        }

        public void Add(T item)
        {
            this.innerList.Add(item);
        }

        public T Remove(int index)
        {
            T result= this.innerList[index];
            this.innerList.RemoveAt(index);
            return result;
        }

        public bool Contains(T element)
        {
            return this.innerList.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            
            T box = this.innerList[index1];
            this.innerList[index1] = this.innerList[index2];
            this.innerList[index2] = box;
        }

        public int CountGreaterThan(T element)
        {
            int counter = 0;
            foreach (var gb in this.innerList)
            {
                if (gb.CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public T Max()
        {
            return this.innerList.Max();
        }

        public T Min()
        {
            return this.innerList.Min();
        }

        

        public void Sort()
        {
            this.innerList.Sort();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
