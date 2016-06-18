using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.Generic_List
{
    public class GenericList<T>: IEnumerable where T : IComparable
    {
       
        private T[] array;
        private int count = 0;
        private int actuallCapacity=16;

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }
        public T[] Array
        {
            get { return this.array; }
            set { this.array = value; }
        }

        public int ActuallCapacity
        {
            get { return this.actuallCapacity; }
            set { this.actuallCapacity = value; }
        }

        public GenericList()
        {
            this.Array = new T[this.ActuallCapacity];
        }

        public void Add(T member)
        {
            if (this.Count== actuallCapacity/2)
            {
                this.Array = Resize();
            }
            this.Array[this.Count] = member;
            this.Count++;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i <this.Count; i++)
            {

               
                output.Append(String.Format("{0}", this.Array[i].ToString()));
                if (i != this.Count - 1)
                {
                    output.Append("\n");
                }
            }
           return output.ToString();
        }

        public T this[int i]
        {
            get
            {
                if (i < 0 || i > this.Count)
                {
                    throw new ArgumentOutOfRangeException("The given argument is out of bound of the array");
                }
                    return this.Array[i];
            }
            set
            {
              
                this.Array[i] = value;
            }
        }

        public void RemoveAtIndex(int givenIndex)
        {
            if (givenIndex > this.Count || givenIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Argument out of range");
            }
            T[] arrayTemp=new T[Count];
            for (int j = 0; j < this.Count; j++)
            {
                if (givenIndex >= j)
                {
                    arrayTemp[j] = this.Array[j];
                }
                else
                {
                    arrayTemp[j-1] = this.Array[j];
                    
                }
                
            }
            this.Count--;
            this.Array = arrayTemp;
        }

        public void InsertAt(T element,int givenPosition)
        {
            if (givenPosition > this.Count || givenPosition< 0)
            {
                throw new ArgumentOutOfRangeException("Argument out of range");
            }
            this.Array = Resize();
            T[] arrayTemp=new T[this.ActuallCapacity];
            for (int i = 0; i < givenPosition; i++)
            {
                arrayTemp[i] = this.Array[i];
            }
            arrayTemp[givenPosition] = element;
            for (int i = givenPosition+1; i <= count; i++)
            {
                arrayTemp[i]= this.Array[i-1];
            }
          
            this.Array = arrayTemp;
            this.Count++;
        }

        public bool Contains(T element)
        {
            bool isContains = false;
            foreach (T member in this.Array)
            {
                if (member.CompareTo(element) == 0)
                {
                    isContains = true;
                }
            }
            return isContains;
        }
        public T[] Resize()
        {
            if (this.Count == actuallCapacity/2)
            {
                actuallCapacity *= 2;
                T[] arrayTemp = new T[actuallCapacity];
                for (int i = 0; i < this.Count; i++)
                {
                    arrayTemp[i] = this.Array[i];
                }
                return this.Array = arrayTemp;
            }
            else
            {
                return this.Array;
            }

        }

        public void Clear()
        {   
            T[] arrayTemp=new T[16];
            this.Array = arrayTemp;
            this.Count = 0;
        }

        public int IndexOf(T element)
        {
            int index = 0;
            int counter = 0;
            foreach (T member in this.Array)
            {
                counter ++;
                if (member.CompareTo(element) == 0)
                {
                    index = counter-1;
                    
                }
            }
            return index;
        }

        public T Max()
        {
            T max = this.Array[0];
            for (int i = 0; i < this.Count; i++)
            {

                if (this.Array[i].CompareTo(max)>0)
                {
                    max = this.Array[i];

                }
            }
            return max;
        }
        public T Min()
        {
            T min= this.Array[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (this.Array[i].CompareTo(min) < 0)
                {
                    min = this.Array[i];

                }
            }
            return min;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this.Array.Take(this.Count).GetEnumerator();
        }

        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }

}

