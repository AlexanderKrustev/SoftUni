namespace _01.GenericBox
{
    using System;


    public class GenericBox<T> where T: IComparable


    {
        public T value;

        public GenericBox(T value)
        {
            this.value = value;
        }

        

        public int CompareTo(T other)
        {
            return this.value.CompareTo(other);
        }

        public override string ToString()
        {
            return this.value.GetType().FullName + ": " + this.value;
        }

        
    }
}
