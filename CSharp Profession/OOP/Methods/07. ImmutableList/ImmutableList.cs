using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ImmutableList
{
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            Type immutableList = typeof(ImmutableList);
            FieldInfo[] fields = immutableList.GetFields();
            if (fields.Length < 1)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(fields.Length);
            }

            MethodInfo[] methods = immutableList.GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
            if (!containsMethod)
            {
                  throw new Exception();
            }
            else
            {
                Console.WriteLine(methods[0].ReturnType.Name);
            }

        }
    }

    public class ImmutableList : Object
    {
        public List<int> elements;
        

        public ImmutableList()
        {
            this.elements = new List<int>();
        }

        public ImmutableList(ImmutableList l)
        {
            this.elements = l.elements;
        }


        public ImmutableList getList()
        {
            return new ImmutableList(this);
        }

    }
}
